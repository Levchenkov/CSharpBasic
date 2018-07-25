using System;
using System.Collections.ObjectModel;

namespace Collections
{
    public class MyDictionary<TKey, TValue> : KeyedCollection<TKey, TValue> where TKey : struct
    {
        private Func<TValue, TKey> getKeyFunc;

        public MyDictionary(Func<TValue, TKey> getKeyFunc)
        {
            this.getKeyFunc = getKeyFunc;
        }

        protected override TKey GetKeyForItem(TValue item)
        {
            return getKeyFunc(item);
        }

        protected override void ClearItems()
        {
            var functionName = nameof(ClearItems);
            Console.WriteLine($"Before {functionName}");
            base.ClearItems();
            Console.WriteLine($"After {functionName}");
        }

        protected override void InsertItem(int index, TValue item)
        {
            var functionName = nameof(InsertItem);
            Console.WriteLine($"Before {functionName}");
            base.InsertItem(index, item);
            Console.WriteLine($"After {functionName}");
        }

        protected override void RemoveItem(int index)
        {
            var functionName = nameof(RemoveItem);
            Console.WriteLine($"Before {functionName}");
            base.RemoveItem(index);
            Console.WriteLine($"After {functionName}");
        }

        protected override void SetItem(int index, TValue item)
        {
            var functionName = nameof(SetItem);
            Console.WriteLine($"Before {functionName}");
            base.SetItem(index, item);
            Console.WriteLine($"After {functionName}");
        }
    }
}