using System;
using System.Collections;
using System.Collections.Generic;

namespace ListsAndBitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lists");
            // List is like an array but elements can be added and removed dynamically
            // The Generic Collection List<T> requires all elments to be of the same type T

            // Some List<T> methods: 

            List<int> li = new List<int>();

            li.Add(56);
            li.Add(2);
            li.Add(1);
            li.Add(86);
            li.Add(6);
            li.Add(26);

            PrintList(li);

            li.RemoveAt(1);

            PrintList(li);

            li.Sort();

            PrintList(li);

            /*
             some noteworthy List<T> methods:
             Capacity: how much space is left before a resize becomes necessary[property]
             Clear(): remove everything
             TrimExcess(): set capacity to the actual number of elements, usefull to free memory
             AddRange(IEnumerable coll): adds the elements of the collection coll to the end of the List<T> [same type required]
                IEnumerable  is the collections interface that supports simple iteration over the collection.
             Insert (int i, T t): insert element t at position i
             InsertRange(int i, IEnumerable coll): inserts the elements of a collection coll at a specific index i
                in List<T>
             Remove(T t): Removes the first occourence of object t in the list
             RemoveRange(int i, int count): guess...
             Contains(T t): returns true if the specified element t is present in the list
             IndexOf(T t): guess...
             Reverse(): reverses the orger of the elements in the list
             toArray(): Copies the elements of the list into a new array
      
             */

            Console.WriteLine("SortedList<K,V>");

            /*
            SortedList is a collection of key/value pairs sorted by key
            Keys are used to retrieve the corresponding values.
            Keys must be unique
            All keys must be of the same type K and values must be of type V

            Some properties
            Count - guess...
            Item[K key] gets or sets the value associated to the specific key.
                Item is the indexer and is not required, you can use the brakets[]
            Keys - gets a sorted and indexed collection containing only  the keys in a sorted list
            
            Some Methods:
            Add(K key, V value) - adds an element with a specific key
            Remove(K key) - removes the key/value pair with the specified key            
             */

            SortedList<string, int> sl = new SortedList<string, int>();
            sl.Add("meaning of life", 42);
            sl.Add("A", 1);
            sl.Add("test", 123);
            PrintSortedList(sl);
            sl.Remove("A");
            PrintSortedList(sl);


            Console.WriteLine("BitArray");
            /*
            Bit Array - Collection of bits
            Usefull to represent a simple group of boolean flags

            Props:
            Count
            IsReadOnly

            Methods:
            Get(int i)
            Set(int i, bool value)
            SetAll(bool value)
            And(BitArray ba)
            Or(BitArray ba)
            Not()
            Xor(BitArray ba)
            */

            BitArray ba1 = new BitArray(4);
            BitArray ba2 = new BitArray(4);

            ba1.SetAll(true);
            ba2.SetAll(false);

            PrintBarr("ba1", ba1);
            PrintBarr("ba2", ba2);
            Console.WriteLine();

            PrintBarr("ba1 And ba2", ba1.And(ba2));
            PrintBarr("Not ba2",  ba1.Not());

            Console.ReadKey();

        }

        static void PrintList(List<int> myList) {
            Console.Write("\n List: ");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i] + " ");
            }
        }


        static void PrintSortedList(SortedList<string,int> mySList)
        {
            Console.Write("\n SortedList: ");
            foreach(string s in mySList.Keys)
            {
                Console.Write(s + ": "+ mySList[s] + " ///");
            }
        }

        static void PrintBarr(string name, BitArray ba)
        {
            Console.WriteLine(name + ": ");
            for (int x = 0; x < ba.Length; x++)
            {
                Console.Write(ba.Get(x) + " ");
            }
            Console.WriteLine();
        }
    }
}
