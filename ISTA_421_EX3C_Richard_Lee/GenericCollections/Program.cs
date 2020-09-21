using System;
using System.Collections.Generic;
using System.Text;
namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List");
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            foreach(var lNum in list)
            {
                Console.WriteLine(lNum);
            }
            Console.WriteLine();
            Console.WriteLine("LinkedList");
            LinkedList<string> DLL = new LinkedList<string>();
            DLL.AddLast("one");
            DLL.AddLast("two");
            DLL.AddLast("three");
            DLL.AddLast("four");
            DLL.AddLast("five");
            foreach (var dStr in DLL)
            {
                Console.WriteLine(dStr);
            }
            Console.WriteLine();
            Console.WriteLine("Queue");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10); 
            foreach (var qNum in queue)
            {
                Console.WriteLine(qNum);
            }
            Console.WriteLine();
            Console.WriteLine("Stack");
            Stack<string> stack = new Stack<string>();
            stack.Push("ten");
            stack.Push("nine");
            stack.Push("eight");
            stack.Push("seven");
            stack.Push("six");
            foreach (var sStr in stack)
            {
                Console.WriteLine(sStr);
            }
            Console.WriteLine();
            Console.WriteLine("Dictionary");
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("eleven", 11);
            dictionary.Add("twelve", 12);
            dictionary.Add("thirteen", 13);
            dictionary.Add("fourteen", 14);
            dictionary.Add("fifteen", 15);
            foreach (var dKeyVal in dictionary)
            {
                Console.WriteLine(dKeyVal);
            }
            Console.WriteLine();
            Console.WriteLine("SortedList");
            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(16, "sixteen");
            sortedList.Add(17, "seventeen");
            sortedList.Add(18, "eighteen");
            sortedList.Add(19, "nineteen");
            sortedList.Add(20, "twenty");
            foreach (var sKeyVal in sortedList)
            {
                Console.WriteLine(sKeyVal);
            }
            Console.WriteLine();
            Console.WriteLine("HashSet");
            HashSet<int> hashSet = new HashSet<int>();
            hashSet.Add(21);
            hashSet.Add(22);
            hashSet.Add(23);
            hashSet.Add(24);
            hashSet.Add(25);
            foreach (var hNum in hashSet)
            {
                Console.WriteLine(hNum);
            }
        }
    }
}
