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
        private static ServerNetworkHandler staticSingleton;
        private TcpListener tcpListener = null;
        private bool isAvailable = false;
        private Action<List<string[]>> takeOrderAcion;
        public static ServerNetworkHandler Instance()
        {
            if (staticSingleton == null)
            {
                staticSingleton = new ServerNetworkHandler();
            }
            return staticSingleton;
        }
        public void acceptClientStart()
        {
            tcpListener = new TcpListener(3000);
            tcpListener.Start();

            Thread thread = new Thread(new ThreadStart(acceptClient));
            thread.IsBackground = true;
            thread.Start();
        }

        public void available(Action<List<string[]>> action)
        {
            isAvailable = true;
            takeOrderAcion = action;
        }
        public void unavailable()
        {
            isAvailable = false;
            takeOrderAcion = null;
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

            while (tcpClient.Connected)
            {
                try
                {
                    binaryReader.ReadByte();
                    binaryWriter.Write(isAvailable);
                    if (!isAvailable)
                        continue;
                    switch (binaryReader.ReadByte())
                    {
                        case (byte)Request.MenuList:
                            sendMenus(binaryWriter);
                            break;
                        case (byte)Request.Order:
                            takeOrder(binaryReader);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            binaryReader.Close();
            binaryWriter.Close();
            networkStream.Close();
            tcpClient.Close();
            Thread.CurrentThread.Abort();
        }

        private void sendMenus(BinaryWriter binaryWriter)
        {
            List<String[]> menus = OrderDbHandler.ReadTable("tblMenu");
            binaryWriter.Write(menus.Count);
            if (menus.Count == 0)
                binaryWriter.Write(0);
            else
                binaryWriter.Write(menus[0].Length - 1);
            foreach (string[] menu in menus)
            {
                string[] temp = menu.Skip(1).ToArray();
                foreach (string data in temp)
                    binaryWriter.Write(data);
            }
                
        }

        private void takeOrder(BinaryReader binaryReader)
        {
            List<string[]> orders = new List<String[]>();
            int listSize = binaryReader.ReadInt32();
            int colunmSize = binaryReader.ReadInt32();
            for (int i = 0; i < listSize; i++)
            {
                List<string> order = new List<string>();
                for (int j = 0; j < colunmSize; j++)
                    order.Add(binaryReader.ReadString());
                orders.Add(order.ToArray());
            }
            takeOrderAcion(orders);
        }
    }
}
