using System;
using System.Collections.Generic;

namespace Lab6
{
    public class Task2
    {
        public IRemoteClient CreateRemoteClient(IRemoteService remoteService)
        {
            return new RemoteClient(remoteService);
        }
    }

    public class RemoteClient : IRemoteClient
    {
        private readonly IRemoteService remoteService;

        public RemoteClient(IRemoteService remoteService)
        {
            this.remoteService = remoteService;
        }

        public IRemoteResult SendData(string[] data)
        {
            throw new NotImplementedException();
        }
    }

    public class RemoteResult : IRemoteResult
    {
        public IEnumerable<Exception> Exceptions => throw new NotImplementedException();

        public bool IsSuccess => throw new NotImplementedException();

        public void Add(Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}
