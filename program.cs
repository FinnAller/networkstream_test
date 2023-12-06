class Program
{
    static void Main(string[] args)
    {
      TcpListener tcplistener = new TcpListener(33533);
      while(true)
      {
        Thread HandleThread = new Thread(HandleThsFuck);
        HandleThread.Start(client);
      }
      static void HandleThisFuck(object obj)
      {
        obj.AcceptConnection();
        NetworkStream stream = obj.GetStream();
        byte[] buffer = Stream.Read();
        int bytes.read
      }
    }
}
