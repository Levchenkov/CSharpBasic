using System;

namespace Lab6
{
    public class File : IFile
    {
        public void Open()
        {
        }

        public void Close()
        {
        }

        public string Read()
        {
            throw new Exception("Bad symbol.");
        }
    }
}
