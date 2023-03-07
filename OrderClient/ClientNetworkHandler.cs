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
        public void getMenus()
        {
            TcpClient tcpClient = new TcpClient();
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3000);
            try
            {
                tcpClient.Connect(ipEndPoint);
                NetworkStream networkStream = tcpClient.GetStream();
                BinaryReader binaryReader = new BinaryReader(networkStream);
                BinaryWriter binaryWriter = new BinaryWriter(networkStream);

                binaryWriter.Write((((byte)Request.MenuList)));
                Console.WriteLine(binaryReader.ReadString());
            }
            catch
            {
                Console.WriteLine("현재 서버가 주문모드로 켜져있지 않습니다.");
            }
            tcpClient.Close();
        }
        public void order()  
        {
            TcpClient tcpClient = new TcpClient(); 
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3000);
            try 
            {
                tcpClient.Connect(ipEndPoint);
                NetworkStream networkStream = tcpClient.GetStream();
                BinaryReader binaryReader = new BinaryReader(networkStream);
                BinaryWriter binaryWriter = new BinaryWriter(networkStream);

                binaryWriter.Write((((byte)Request.Order)));
                Console.WriteLine(binaryReader.ReadString());
            }
            catch
            {
                Console.WriteLine("현재 서버가 주문모드로 켜져있지 않습니다.");
            }
            tcpClient.Close();
        }
    }
}
