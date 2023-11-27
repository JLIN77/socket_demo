private void socket_server()
{
    string ip = "192.168.0.14"; // IP
    int port = 1111;            // PORT
    Console.WriteLine("Server startup.....");
    
    Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);  //create server
    //绑定对应的IP与端口号
    EndPoint point = new IPEndPoint(IPAddress.Parse(ip), port);
    server.Bind(point);
    server.Listen(100);
    //设置接收消息
    Socket socket = server.Accept();
    while (true)
    {
        byte[] bytes = new byte[1024];
        int len = socket.Receive(bytes);
        string msg = Encoding.UTF8.GetString(bytes, 0, len);
        Console.WriteLine(msg);
    }
}
