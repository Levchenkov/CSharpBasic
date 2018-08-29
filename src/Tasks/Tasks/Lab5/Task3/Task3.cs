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
        public int Count => throw new System.NotImplementedException();

        public bool IsEmpty => throw new System.NotImplementedException();

        public T Dequeue()
        {
            throw new System.NotImplementedException();
        }

        public void Enqueue(T value)
        {
            throw new System.NotImplementedException();
        }

        public T Peek()
        {
            throw new System.NotImplementedException();
        }

        public T[] ToArray()
        {
            throw new System.NotImplementedException();
        }
    }
}