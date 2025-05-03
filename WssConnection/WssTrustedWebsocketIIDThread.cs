namespace XboxClientQA.WssConnection
{
    public class WssTrustedWebsocketIIDThread
    {
        public Action<byte[]> m_onBytesReceived;
        public Action<string> m_onStringReceived;

        private WssTrustedWebsocketIID m_client;

        public WssTrustedWebsocketIIDThread(WssTrustedWebsocketIID client)
        {
            m_client = client;
            LaunchLoopListener();
        }

        public WssTrustedWebsocketIIDThread(string serverUrl = "wss://apint.ddns.net:4725")
        {
            WssTrustedWebsocketIID gameStateAsInt = new WssTrustedWebsocketIID(false);
            gameStateAsInt.m_onPrint = (str) =>
            {
                Console.WriteLine(str);
            };
            gameStateAsInt.SetServerUrl(serverUrl);
            gameStateAsInt.StartConnectionThread();
            m_client = gameStateAsInt;

            LaunchLoopListener();
        }

        public void AddBytesReceived(Action<byte[]> onBytesReceived)
        {
            m_onBytesReceived += onBytesReceived;
        }
        public void AddStringReceived(Action<string> onStringReceived)
        {
            m_onStringReceived += onStringReceived;
        }

        public void PushBytes(byte[] bytes)
        {
            m_client.m_sendBytesQueue.Enqueue(bytes);
        }
        public void PushString(string str)
        {
            m_client.m_sendStringQueue.Enqueue(str);
        }
        public void PushInteger(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            m_client.m_sendBytesQueue.Enqueue(bytes);
        }
        public void PushIndexInteger(int index, int value)
        {
            byte[] bytes =new byte[8];
            BitConverter.GetBytes(index).CopyTo(bytes, 0);
            BitConverter.GetBytes(value).CopyTo(bytes, 4);
            m_client.m_sendBytesQueue.Enqueue(bytes);
        }

        private async Task FlushReceivedQueuesAsync()
        {
            await Task.Run(() =>
            {
                while (!m_client.m_kill)
                {
                    m_client.FlushReceivedWaitingInQueue(bytes =>
                    {
                        m_onBytesReceived?.Invoke(bytes);
                    });

                    m_client.FlushReceivedWaitingInQueue(str =>
                    {
                        m_onStringReceived?.Invoke(str);
                    });

                    Thread.Sleep(10); // Prevent CPU overuse
                }
            });
        }

        private void LaunchLoopListener()
        {
            _ = FlushReceivedQueuesAsync();
        }
        public void SetOnBytesReceived(Action<byte[]> onBytesReceived)
        {
            m_onBytesReceived = onBytesReceived;
        }

        ~WssTrustedWebsocketIIDThread()
        {
            // Ensure the client connection is stopped and resources are released
            m_client?.StopConnectionThread();
            m_client = null;
        }
    }

}