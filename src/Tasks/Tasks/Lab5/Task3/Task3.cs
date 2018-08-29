namespace Lab5
{
    public class Task3
    {
        public IQueue<int> CreateQueue()
        {
            return new LinkedQueue<int>();
        }
    }

    public class LinkedQueue<T> : IQueue<T>
    {

    }
}