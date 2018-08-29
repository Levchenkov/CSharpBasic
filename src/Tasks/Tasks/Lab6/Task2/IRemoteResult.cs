using System;
using System.Collections.Generic;

namespace Lab6
{
    public interface IRemoteResult
    {
        IEnumerable<Exception> Exceptions
        {
            get;
        }

        void Add(Exception exception);

        bool IsSuccess
        {
            get;
        }
    }
}
