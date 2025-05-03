using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.WebSockets;
using System.Text;
using System.Threading;

namespace XboxClientQA.WssConnection
{
    /// <summary>
    /// I am a class that allows a connection to a websocket server using the WS WSS protocol without password.
    /// </summary>
    [Serializable]
    public class WssTrustedWebsocketIID
    {
        ///Unity version https://github.com/EloiStree/2025_05_01_TrustedWebsocket
        //C# in Scratch2Warcraft https://github.com/EloiStree/2025_02_05_WarcraftClientQA
        public string m_serverUrl = "wss://apint.ddns.net:4725";
        private Thread? connectionThread;
        private bool isRunning = false;
        public ClientWebSocket? m_clientWebSocket = null;
        public Thread m_receiveThread;
        public Queue<byte[]> m_sendBytesQueue = new Queue<byte[]>();
        public Queue<string> m_sendStringQueue = new Queue<string>();
        public Queue<byte[]> m_receivedBytesQueue = new Queue<byte[]>();
        public Queue<string> m_receivedStringQueue = new Queue<string>();

        public bool m_kill = false;
        public Action<string> m_onPrint;



        public void FlushReceivedWaitingInQueue(Action<byte[]> toRedirect)
        {
            if (m_receivedBytesQueue == null) return;
            if (m_receivedBytesQueue.Count <= 0) return;
            lock (m_receivedBytesQueue)
            {
                if (m_receivedBytesQueue.Count <= 0) return;
            }
            if (toRedirect == null) return;
            while (m_receivedBytesQueue.Count > 0)
            {
                byte[] bytes = m_receivedBytesQueue.Dequeue();
                toRedirect?.Invoke(bytes);
            }

        }
        public void FlushReceivedWaitingInQueue(Action<string> toRedirect)
        {
            if (m_receivedStringQueue == null) return;
            if (m_receivedStringQueue.Count <= 0) return;
            lock (m_receivedStringQueue)
            {
                if (m_receivedStringQueue.Count <= 0) return;
            }

            if (toRedirect == null) return;

            while (m_receivedStringQueue.Count > 0)
            {
                string str = m_receivedStringQueue.Dequeue();
                toRedirect?.Invoke(str);
            }

        }

        public WssTrustedWebsocketIID(bool autoStart)
        {
            m_kill = false;
            m_clientWebSocket = null;
            m_onPrint = null;
            if (autoStart)
            {
                StartConnectionThread();
            }
        }

        public void SetServerOnDefaultApintTrustedWSS()
        {
            m_serverUrl = "wss://apint.ddns.net:4725";
        }
        public void SetServerOnDefaultApintTrustedWS()
        {
            m_serverUrl = "wss://apint.ddns.net:4625";
        }
        public void SetServerOnDefaultRaspberryPiTrustedWS()
        {
            m_serverUrl = "ws://raspberrypi:4625";
        }
        public void SetServerOnDefaultRaspberryPiTrustedWSS()
        {
            m_serverUrl = "wss://raspberrypi:4625";
        }

        public void StartConnectionThread()
        {
            if (connectionThread == null || !connectionThread.IsAlive)
            {
                isRunning = true;
                connectionThread = new Thread(MaintainConnection);
                connectionThread.IsBackground = true;
                connectionThread.Start();

                m_receiveThread = new Thread(ListenToIncomingMessage);
                m_receiveThread.IsBackground = true;
                m_receiveThread.Start();
            }
        }

        public void StopConnectionThread()
        {
            isRunning = false;
            connectionThread?.Join();
        }


        private void ListenToIncomingMessage()
        {
            var buffer = new byte[4096]; // Consider a larger buffer for text frames

            while (isRunning)
            {
                try
                {
                    if (m_clientWebSocket == null || m_clientWebSocket.State != WebSocketState.Open)
                    {
                        Thread.Sleep(2000);
                        continue;
                    }

                    var memoryStream = new MemoryStream();
                    WebSocketReceiveResult result;

                    do
                    {
                        result = m_clientWebSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None).Result;
                        memoryStream.Write(buffer, 0, result.Count);
                    } while (!result.EndOfMessage);

                    var messageBytes = memoryStream.ToArray();

                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        m_clientWebSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing", CancellationToken.None).Wait();
                        Thread.Sleep(2000);
                    }
                    else if (result.MessageType == WebSocketMessageType.Text)
                    {
                        string messageText = Encoding.UTF8.GetString(messageBytes);
                        lock (m_receivedStringQueue)
                        {
                            m_receivedStringQueue.Enqueue(messageText);
                        }
                    }
                    else if (result.MessageType == WebSocketMessageType.Binary)
                    {
                        lock (m_receivedBytesQueue)
                        {
                            m_receivedBytesQueue.Enqueue(messageBytes);
                        }
                    }
                }
                catch (Exception ex)
                {
                    PrintDebug($"Error in listener: {ex.Message}");
                    Thread.Sleep(2000);
                }
            }
        }


        private void MaintainConnection()
        {
            while (isRunning)
            {
                try
                {
                    using (var client = new ClientWebSocket())
                    {
                        m_clientWebSocket = client;
                        PrintDebug("Attempting to connect to server:" + m_serverUrl);

                        // If the URL uses "wss", allow self-signed certificates
                        if (m_serverUrl.StartsWith("wss", StringComparison.OrdinalIgnoreCase))
                        {
                            client.Options.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
                        }

                        client.ConnectAsync(new Uri(m_serverUrl), CancellationToken.None).Wait();
                        PrintDebug("Connection established.");

                        // Start receiving messages in a separate thread

                        // Keep the connection alive until disconnected
                        while (client.State == WebSocketState.Open && isRunning)
                        {
                            Thread.Sleep(1); // Check connection state periodically
                            while (m_sendBytesQueue.Count > 0)
                            {
                                byte[] bytesToSend = m_sendBytesQueue.Dequeue();
                                client.SendAsync(new ArraySegment<byte>(bytesToSend), WebSocketMessageType.Binary, true, CancellationToken.None).Wait();
                            }
                            while (m_sendStringQueue.Count > 0)
                            {
                                string textToSend = m_sendStringQueue.Dequeue();
                                byte[] bytesToSend = Encoding.UTF8.GetBytes(textToSend);
                                client.SendAsync(new ArraySegment<byte>(bytesToSend), WebSocketMessageType.Text, true, CancellationToken.None).Wait();
                            }
                        }

                        PrintDebug("Connection lost.");
                    }
                }
                catch (Exception ex)
                {
                    PrintDebug($"Connection failed: {ex.Message}");
                    PrintDebug($"Stack Trace: {ex.StackTrace}");

                }

                Thread.Sleep(5000);
            }
        }

        public void PrintDebug(string message)
        {
            if (m_onPrint != null)
            {
                m_onPrint(message);
            }
        }

        public void SetServerUrl(string serverUrl)
        {
            m_serverUrl = serverUrl;
        }

        public void AddQueueBytes(byte[] bytes)
        {
            lock (m_sendBytesQueue)
            {
                m_sendBytesQueue.Enqueue(bytes);
            }
        }

        public void AddToQueueString(string text)
        {
            lock (m_sendStringQueue)
            {
                m_sendStringQueue.Enqueue(text);
            }
        }
    }

}