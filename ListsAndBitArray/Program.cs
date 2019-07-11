using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static void PrintList(List<int> myList) {
            Console.Write("\n List: ");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i] + " ");
            }
        }
    }
}
