using Lab6;

namespace Tasks.Lab6.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new File();
            var fileReader = new FileReader(file);

            System.Console.WriteLine(fileReader.ReadSafe());
        }
    }
}
