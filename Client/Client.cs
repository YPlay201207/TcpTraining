using System;
using System.Net.Sockets;

namespace ClientClassNamespace{
    public class ClientClass{

        private string _serverAddress;

        public void Connect()
        {
            Int32 port = 13000;
            TcpClient client = new TcpClient(_ServerAddress, port);
            NetworkStream stream = client.GetStream();
        }
    }
}