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