namespace Lab5
{
    public class Task2
    {
        public IQueue<int> CreateQueue()
        {
            return new Queue<int>();
        }
    }

    public class Queue<T> : IQueue<T>
    {
        
    }
}