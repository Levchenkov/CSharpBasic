using Lab5;

namespace Tasks.Lab5.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueue<int> queue = new Queue<int>(); // todo: implement

            queue.Enqueue(10);

            System.Console.WriteLine(queue.Peek());
            System.Console.WriteLine(queue.Dequeue());
        }
    }    
}
