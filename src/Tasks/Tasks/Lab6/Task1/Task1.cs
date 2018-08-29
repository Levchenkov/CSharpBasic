using Lab6;
using System;
using System.Runtime.Serialization;

namespace Lab6
{
    public class Task1
    {
        public IFileReader CreateHandler(IFile file)
        {
            return new FileReader(file);
        }
    }

    public class FileReaderException : Exception
    {
    }

    public class FileReader : IFileReader
    {
        private readonly IFile file;

        public FileReader(IFile file)
        {
            this.file = file;
        }

        public string Read()
        {
            throw new NotImplementedException();
        }

        public string ReadSafe()
        {
            throw new NotImplementedException();
        }
    }
}
