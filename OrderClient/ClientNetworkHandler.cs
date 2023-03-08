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

        public void connect()
        {
            try
            {
                tcpClient.Connect(ipEndPoint);
                networkStream = tcpClient.GetStream();
                binaryReader = new BinaryReader(networkStream);
                binaryWriter = new BinaryWriter(networkStream);
            }
            catch
            {
                Console.WriteLine("현재 서버에 연결할 수 없습니다.");
            }
        }

        public List<string[]> getMenus()
        {
            List<string[]> menus = new List<String[]>();
            if (checkAvailable())
            {

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
            }
            return menus;
        }
        public void order()  
        {
            if (checkAvailable())
            {
                binaryWriter.Write((byte)Request.Order);
                Console.WriteLine(binaryReader.ReadString());
            }
        }

        private bool checkAvailable()
        {
            byte checkAvailable = 0;
            binaryWriter.Write(checkAvailable);
            bool isAvailable = binaryReader.ReadBoolean();
            if (!isAvailable)
                Console.WriteLine("주문 모드가 아닙니다.");
            return isAvailable;
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
