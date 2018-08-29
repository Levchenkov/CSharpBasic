using Lab6;

namespace Tasks.Lab6.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new string[]
            {
                "1",
                "2",
                "3"
            };

            var remoteService = new RemoteService();
            var remoteClient = new RemoteClient(remoteService);

            var result = remoteClient.SendData(data);

            foreach (var item in result.Exceptions)
            {
                System.Console.WriteLine(item.Message);
            }
        }
    }
}
