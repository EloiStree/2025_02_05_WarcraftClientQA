using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XboxClientQA.UdpListenerToIID
{
    using System;
    using System.Net;
    using System.Net.Sockets;
    using System.Threading.Tasks;
    using System.Threading;
    using System.Reflection;


    public static class ParseGivenBytesToIntegerFromIID
    {
        public static int ParseByteToInt(byte[] data)
        {
            if (data == null || data.Length == 0)
            {
                throw new ArgumentException("Data cannot be null or empty.");
            }
            if (data.Length == 4)
            {
                return BitConverter.ToInt32(data, 0);
            }
            else if (data.Length == 8)
            {
                return BitConverter.ToInt32(data, 4);
            }
            else if (data.Length == 16)
            {
                return BitConverter.ToInt32(data, 4);
            }
            else if (data.Length == 12)
            {
                return BitConverter.ToInt32(data, 0);
            }
            else
            {
                throw new ArgumentException("Invalid data length.");
            }
        }
    }
    class UDPListenerBytesToIID
    {
        int m_udpPort;
        UdpClient m_udpClient;
        CancellationTokenSource cts = new CancellationTokenSource();
        public Action<byte[]> m_onBytesToHandle;


        public UDPListenerBytesToIID(int portToListen = 6999)
        {
            m_udpPort = portToListen;
             m_udpClient = new UdpClient(m_udpPort);
            Thread listenerThread = new Thread(() => ListenAsync(cts.Token).GetAwaiter().GetResult())
            {
                IsBackground = true
            };
            listenerThread.Start();
        }

        private  async Task ListenAsync(CancellationToken token)
        {
            try
            {
                while (!token.IsCancellationRequested)
                {
                    UdpReceiveResult result = await m_udpClient.ReceiveAsync();
                    byte[] data = result.Buffer;

                    if (data ==null || data.Length == 0)
                    {
                        continue;
                    }
                    m_onBytesToHandle?.Invoke(data);


                }
            }
            
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private static void ChampionIndexTagValueExample (int integerValue)
        {
            Console.WriteLine($"Received integer value: {integerValue}");

            int playerId = (integerValue / 100000000) % 100;
            int dataTag = (integerValue / 1000000) % 100;
            int dataValue = integerValue % 1000000;

            Console.WriteLine($"Player ID: {playerId}, Data Tag: {dataTag}, Data Value: {dataValue}");
        }

        internal void AddBytesReceivedHandler(Action<byte[]> pushInBytesIID)
        {
            if (pushInBytesIID == null)
            {
                throw new ArgumentNullException(nameof(pushInBytesIID));
            }
            m_onBytesToHandle += pushInBytesIID;
        }
    }

}
