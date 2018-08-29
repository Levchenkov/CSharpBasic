using System;

namespace Lab6
{
    public class RemoteService : IRemoteService
    {
        public void SendData(string data)
        {
            throw new Exception(data);
        }
    }
}
