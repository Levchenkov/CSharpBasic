using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Collections
{
    /// <summary>
    /// Links: 
    /// 1) About collections on russian: https://blog.rc21net.ru/%D0%BA%D0%BE%D0%BB%D0%BB%D0%B5%D0%BA%D1%86%D0%B8%D0%B8-%D0%B2-c-sharp/
    /// 2) About collections on MSDN: https://msdn.microsoft.com/en-us/library/system.collections(v=vs.110).aspx
    /// 3) About collections on Docs (but not in this case): https://docs.microsoft.com/en-us/dotnet/standard/collections/commonly-used-collection-types
    /// 4) Source code of BCL: https://referencesource.microsoft.com/
    /// 5) Source code for lessons: https://github.com/Levchenkov/CSharpBasic
    /// *) Hidden features of C#: https://stackoverflow.com/questions/9033/hidden-features-of-c
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //defenition
            List<object> sourceList = new List<object> { "a1", "b2", "c3", 1, 2, 3, DateTime.Now };

            #region IEnumerable and IEnumerator

            //IEnumerator<T>
            //IEnumerable<T>

            //IEnumerable<object> enumerable = (IEnumerable<object>)sourceList;

            //foreach (var item in enumerable)
            //{
            //    Console.WriteLine(item);
            //}

            //IEnumerator<object> enumerator = enumerable.GetEnumerator();

            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}

            #endregion

            #region ICollection
            //ICollection<T>

            //ICollection<object> collection = (ICollection<object>)sourceList;

            //collection.Add("d4");
            //collection.Remove(1);
            //Console.WriteLine($"Does contain a1: {collection.Contains("a1")}");

            //Console.WriteLine($"Count: {collection.Count}");

            //foreach (var item in collection)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region IList and IReadOnlyList
            //IList<T>
            //IReadOnlyList<T>

            //IList<object> list = (IList<object>)sourceList;

            //Console.WriteLine($"Count: {list.Count}");
            //list.RemoveAt(6);
            //list.Add(4);
            ////arrayList.Clear();
            //Console.WriteLine($"Does contain 4: {list.Contains(4)}");
            //list.Insert(3, 0);
            //Console.WriteLine($"Element at index 3: {list[3]}");

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //IReadOnlyList<object> readOnlyList = (IReadOnlyList<object>)sourceList;

            //Console.WriteLine($"Count: {readOnlyList.Count}");
            ////readOnlyList.RemoveAt(6); // compile error
            ////readOnlyList.Add(4); // compile error
            ////readOnlyList.Clear(); // compile error
            ////readOnlyList.Insert(3, 0); // compile error
            //Console.WriteLine($"Element at index 3: {readOnlyList[3]}");

            //for (int i = 0; i < readOnlyList.Count; i++)
            //{
            //    Console.WriteLine(readOnlyList[i]);
            //}

            #endregion

            #region Array

            //var array = new object[] { "a1", "b2", "c3", 1, 2, 3, DateTime.Now };
            //Console.WriteLine($"Length: {array.Length}");
            //array[6] = 4;
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Queue, Stack and LinkedList

            //var queue = new Queue<object>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //var firstDequeue = queue.Dequeue();
            //Console.WriteLine($"First dequeue: {firstDequeue}");

            //var stack = new Stack<object>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //var firstPop = stack.Pop();
            //Console.WriteLine($"Fitst pop: {firstPop}");

            //var linkedList = new LinkedList<object>(sourceList);
            //Console.WriteLine($"Count: {linkedList.Count}");
            //Console.WriteLine($"First: {linkedList.First}");
            //Console.WriteLine($"Last: {linkedList.Last}");
            //linkedList.AddFirst(0);
            //linkedList.AddLast(10);

            //foreach (var item in linkedList)
            //{
            //    Console.WriteLine(item);
            //}

            //linkedList.RemoveFirst();
            //linkedList.RemoveLast();

            #endregion

            #region HashSet<T>

            //var hashSet = new HashSet<int> { 1, 1, 2, 1, 3, 3 };

            //hashSet.Add(2);

            //foreach (var item in hashSet)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            var sourceDictionary = new Dictionary<int, string>
            {
                { 5, "e5" },
                { 2, "b2" },
                { 1, "a1" },
                { 4, "d4" }
            };

            #region IDictionary and IReadOnlyDictionary

            //IDictionary<int, string> dictionary = sourceDictionary;

            //dictionary.Add(3, "c3");
            //Console.WriteLine($"Does contains entry with key 3: {dictionary.ContainsKey(3)}");

            //dictionary.Remove(5);
            //Console.WriteLine($"Does contains entry with key 5: {dictionary.ContainsKey(5)}");

            //Console.WriteLine($"Value with key 4: {dictionary[4]}");
            //dictionary[4] = "new d4";

            //Console.WriteLine($"Count: {dictionary.Count}\n");

            //foreach (KeyValuePair<int, string> pair in dictionary)
            //{
            //    Console.WriteLine(pair);
            //    Console.WriteLine($"Key: {pair.Key} Value: {pair.Value}");
            //    Console.WriteLine();
            //}

            //IReadOnlyDictionary<int, string> readOnlyDictionary = sourceDictionary;

            ////readOnlyDictionary.Add(3, "c3"); // compile error
            ////readOnlyDictionary.Remove(5); // compile error
            ////readOnlyDictionary[4] = "new d4"; // compile error

            //Console.WriteLine($"Value with key 4: {readOnlyDictionary[4]}");

            //foreach (var pair in readOnlyDictionary)
            //{
            //    Console.WriteLine(pair);
            //}

            #endregion

            #region ReadOnly collections

            ////var readOnlyCollection = new ReadOnlyCollection<object> {"a1", "b2", "c3", 1, 2, 3, DateTime.Now}; // compile error
            //var readOnlyCollection = new ReadOnlyCollection<object>(sourceList);

            //Console.WriteLine($"Count: {readOnlyCollection.Count}");
            ////readOnlyCollection.RemoveAt(6); // compile error
            ////readOnlyCollection.Add(4); // compile error
            ////readOnlyCollection.Clear(); // compile error
            ////readOnlyCollection.Insert(3, 0); // compile error
            ////readOnlyCollection[0] = 0; // compile error
            //Console.WriteLine($"Element at index 3: {readOnlyCollection[3]}");

            //for (int i = 0; i < readOnlyCollection.Count; i++)
            //{
            //    Console.WriteLine(readOnlyCollection[i]);
            //}

            //var readOnlyDictionary = new ReadOnlyDictionary<int, string>(sourceDictionary);

            ////readOnlyDictionary.Add(3, "c3"); // compile error
            ////readOnlyDictionary.Remove(5); // compile error
            ////readOnlyDictionary[4] = "new d4"; // compile error

            //foreach (var pair in readOnlyDictionary)
            //{
            //    Console.WriteLine(pair);
            //}

            #endregion

            #region Old Collections

            var arrayList = new ArrayList(); // list
            var hashtable = new Hashtable(); // dictionary
            var listDictionary = new ListDictionary(); // linked list
            var hybridDictionary = new HybridDictionary(); // mix of Hashtable and ListDictionary

            #endregion

            #region Sorted dictionaries

            //var sortedList = new SortedList<int, object>
            //{
            //    { 5, "e5" },
            //    { 2, "b2" },
            //    { 1, "a1" },
            //    { 4, "d4" }
            //};

            //sortedList.Add(3, "c3");

            //foreach (var item in sortedList)
            //{
            //    Console.WriteLine(item);
            //}

            //var listForSorting = new List<int> {5, 2, 1, 4};
            //listForSorting.Add(3);

            //listForSorting.Sort();

            //foreach (var item in listForSorting)
            //{
            //    Console.WriteLine(item);
            //}

            //var sortedDictionary = new SortedDictionary<Int16, object>
            //{
            //    { 5, "e5" },
            //    { 2, "b2" },
            //    { 1, "a1" },
            //    { 4, "d4" }
            //};

            //sortedDictionary.Add(3, "c3");

            //foreach (var item in sortedDictionary)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Custom collections

            //CollectionBase // ArrayList
            //Collection<T>
            //DictionaryBase // Hashtable
            //KeyedCollection<TKey,TItem> 

            //var myList = new MyList<object> { "a1", "b2", "c3", 1, 2, 3, DateTime.Now };

            //myList.Remove("c3");
            //myList.Add("d4");
            //myList[0] = 0;
            //myList.Clear();

            //var myDictionary = new MyDictionary<int, object>(value => value.GetHashCode());

            //myDictionary.Add("a1");
            //myDictionary.Add("c3");
            //myDictionary.Remove("a1");
            //myDictionary.Clear();

            #endregion
        }
    }
}
