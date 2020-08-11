using System;
using System.Collections.Generic;

namespace TaskLinkedList
{
    class Program
    {
        public static LinkedList<int> SumLinkedList()
        {
            LinkedList<int> firstList = new LinkedList<int>();
            firstList.AddFirst(2);
            firstList.AddLast(1);
            LinkedList<int> secodnList = new LinkedList<int>();
            secodnList.AddFirst(3);
            secodnList.AddLast(2);

            LinkedList<int> completeList = new LinkedList<int>();
            LinkedList<int> sumList = new LinkedList<int>();
            LinkedListNode<int> node;

            for (node = firstList.First; node != null; node = node.Next)
            {
                Console.WriteLine("First : " + node.Value);
                completeList.AddLast(node.Value);
            }
            for (node = secodnList.First; node != null; node = node.Next)
            {
                Console.WriteLine("Second " + node.Value);
                completeList.AddAfter(completeList.Last, node.Value);
            }

            sumList.AddFirst(completeList.First.Value + completeList.First.Next.Value);
            sumList.AddFirst(completeList.Last.Value + completeList.Last.Previous.Value);
            completeList.AddAfter(completeList.Last, completeList.Last.Previous.Value);
            foreach (var item in sumList)
            {
                Console.WriteLine($"LinkedList sum result: {item}");
            }
            return sumList;
        }

        static void Main(string[] args)
        {

            var s = SumLinkedList();

            Console.ReadLine();
        }
    }
}
