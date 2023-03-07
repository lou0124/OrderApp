using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace OrderServer
{
    public enum Request 
    { 
        MenuList,
        Order
    }
    internal class ServerNetworkHandler
    {
        private TcpListener tcpListener = null;
        public ServerNetworkHandler()
        {
            tcpListener = new TcpListener(3000);
            tcpListener.Start();

            Thread thread = new Thread(new ThreadStart(acceptClient));
            thread.IsBackground = true;
            thread.Start();
        }

        private void acceptClient()
        {
            while (true)
            {
                try
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();
                    Thread thread = new Thread(new ThreadStart(() => process(tcpClient)));
                    thread.IsBackground = true;
                    thread.Start();
                }
                catch
                {
                    Thread.CurrentThread.Abort();
                }
            }
        }

        private void process(TcpClient tcpClient)
        {
            NetworkStream networkStream = tcpClient.GetStream();
            BinaryReader binaryReader = new BinaryReader(networkStream);
            BinaryWriter binaryWriter = new BinaryWriter(networkStream);

            switch (binaryReader.ReadByte())
            {
                case (byte)Request.MenuList:
                    binaryWriter.Write("메뉴들");
                    break;
                case (byte)Request.Order:
                    binaryWriter.Write("주문완료");
                    break;
            }

            binaryReader.Close();
            binaryWriter.Close();
            networkStream.Close();
            tcpClient.Close();
            Thread.CurrentThread.Abort();
        }

        public void listenerStop() 
        {
            if (tcpListener != null)
            {
                tcpListener.Stop();
                tcpListener = null;
            }
        }
        ~ServerNetworkHandler()
        {
            listenerStop();
        }
    }
}
