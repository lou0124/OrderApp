using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;  
using System.IO;
using OrderServer;

namespace OrderClient
{
    internal class ClientNetworkHandler
    {
        private TcpClient tcpClient = null;
        private IPEndPoint ipEndPoint = null;
        private NetworkStream networkStream = null;
        private BinaryReader binaryReader = null;
        private BinaryWriter binaryWriter = null;
        public ClientNetworkHandler()
        {
            tcpClient = new TcpClient();
            ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3000);
        }

        public bool connect()
        {
            try
            {
                tcpClient.Connect(ipEndPoint);
                networkStream = tcpClient.GetStream();
                binaryReader = new BinaryReader(networkStream);
                binaryWriter = new BinaryWriter(networkStream);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool connected()
        {
            return tcpClient.Connected;
        }
        public bool checkAvailable()
        {
            byte checkAvailable = 0;
            binaryWriter.Write(checkAvailable);
            return binaryReader.ReadBoolean();
        }

        public List<string[]> getMenus()
        {
            List<string[]> menus = new List<String[]>();

            binaryWriter.Write((byte)Request.MenuList);
            int listSize = binaryReader.ReadInt32();
            int colunmSize = binaryReader.ReadInt32();
                
            for (int i = 0; i < listSize; i++)
            {
                List<string> menu = new List<string>();
                for (int j = 0; j < colunmSize; j++)
                    menu.Add(binaryReader.ReadString());
                menus.Add(menu.ToArray());
            }
            return menus;
        }
        public void order(List<string[]> orders)  
        {
            binaryWriter.Write((byte)Request.Order);
            binaryWriter.Write(orders.Count);
            if (orders.Count == 0)
                binaryWriter.Write(0);
            else 
                binaryWriter.Write(orders[0].Length);
            foreach (string[] order in orders)
                foreach (string data in order)
                    binaryWriter.Write(data);
        }

        ~ClientNetworkHandler()
        {
            binaryWriter.Close();
            binaryReader.Close();
            networkStream.Close();
            tcpClient.Close();
        }
    }
}
