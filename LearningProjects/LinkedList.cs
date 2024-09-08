using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProjects
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public void PrintLinkedList(LinkedList linkedList)
        {
            // print linkedlist
            var current = linkedList.Head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.Next;
            }
        }
        public void PrintReversedLinkedList(LinkedList linkedList)
        {
            // print linkedlist
            var current = linkedList.Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.Prev;
            }
        }

        public void AddLinkedList(int[] arr, LinkedList linkedList)
        {
            // Add in linkedlist

            Node prev = null;
            var count = 0;
            foreach (var item in arr)
            {
                var node = new Node();
                node.data = item;
                if (prev != null)
                {
                    prev.Next = node;
                }
                node.Prev = prev;
                prev = node;
                if (count == 0)
                {
                    linkedList.Head = node;

                }
                count++;
            }
        }

        public void ReverseLinkedList(LinkedList linkedList)
        {
            Node prev = null;
            Node next = null;
            Node current = linkedList.Head;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                current.Prev = next;
                prev = current;
                current = next;
                if (current != null && current.Next == null)
                {
                    linkedList.Head = current;
                }
            }
        }

        public static void Do()
        {
            // linkedlist
            var linkedList = new LinkedList();
            var arr = new[] { 50, 60, 70, 80 };
            linkedList.AddLinkedList(arr, linkedList);

            linkedList.PrintLinkedList(linkedList);

            linkedList.PrintReversedLinkedList(linkedList);

            //linkedList.ReverseLinkedList(linkedList);

            //linkedList.PrintLinkedList(linkedList);
        }
        public static void MergeArray1()
        {
            int[] arr1 = { 1, 4, 5, 21, 34 };
            int[] arr2 = { 3, 7, 11, 18, 33,35,45,65 };
            List<int> arr = new List<int>();

            int indexArr1 = 0, indexArr2 = 0;

            while (indexArr1 < arr1.Length && indexArr2 < arr2.Length)
            {
                if (arr1[indexArr1] <= arr2[indexArr2])
                {
                    arr.Add(arr1[indexArr1]);
                    indexArr1++;
                }
                else
                {
                    arr.Add(arr2[indexArr2]);
                    indexArr2++;

                }
            }
            if (indexArr1 < arr1.Length)
            {
                while (indexArr1 < arr1.Length)
                {
                    arr.Add(arr1[indexArr1]);
                    indexArr1++;
                }
            }

            if (indexArr2 < arr2.Length)
            {
                while (indexArr2 < arr2.Length)
                {
                    arr.Add(arr2[indexArr2]);
                    indexArr2++;
                }
            }
        }

        public static void MergeArray2() 
        {
            string ss = "asd";
            ss.Substring(1,1);
            
        }
    }
    public class Node
    {
        public int data { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }
    }

}
