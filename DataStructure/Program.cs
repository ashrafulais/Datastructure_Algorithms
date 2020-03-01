using System;
using System.Collections.Generic;

namespace DataStructure
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
    }

    public class LinkedList
    {
        public Node Head;
        public LinkedList()
        {
            Head = null;
        }
        
        public Node GetHead()
        {
            if (Head == null)
            {
                Head = new Node();
            }
            return Head;
        }
        
        public void Insert(int val)
        {
            Console.WriteLine($"Inserting {val}");

            Node newNode = new Node();
            newNode.Data = val;
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node Current = Head;
                Node Parent;
                while(true)
                {
                    Parent = Current;
                    Current = Current.Next;

                    if(Current == null)
                    {
                        Parent.Next = newNode;
                        return;
                    }
                }
            }
        }

        public void ShowAll()
        {
            Console.WriteLine("\n>Reading all data from the LinkedList:");
            Node Current = Head;
            if (Current != null)
            {
                while (Current != null)
                {
                    Console.WriteLine(Current.Data);
                    Current = Current.Next;
                }
            }
            else
            {
                Console.WriteLine("Empty linked list");
            }
        }

        public void Delete(int val)
        {

            Console.WriteLine("\n>Deleting {0}", val);
            //strategy
            //Head.Next = Head.Next.Next;

            Node Current = Head;
            Node Previous = null;

            while (Current != null)
            {
                if (Current.Data == val)
                {
                    Current = Current.Next;
                    Previous.Next = Current;

                    Console.WriteLine("Deletion Successful");
                    return;
                }
                Previous = Current;
                Current = Current.Next;
            }
            Console.WriteLine("Deletion Failed");
        }

        public void Edit(int findValue, int modifiedValue)
        {
            Console.WriteLine("\n>Updating {0} to {1}", findValue, modifiedValue);

            Node Current = Head;

            while(Current != null)
            {
                if(Current.Data == findValue)
                {
                    Current.Data = modifiedValue;
                    Console.WriteLine("Successfully updated");
                    break;
                }
                Current = Current.Next;
            }
            Console.WriteLine("Failed updating");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var List = new LinkedList();
            var insertList = new List<int>() { 1, 3, 4, 6, 2, 0 };

            //Inserting values
            foreach(var val in insertList)
            {
                List.Insert(val);
            }
            List.Delete(2);
            
            //Showing values
            List.ShowAll();

            List.Edit(0, 7);

            List.ShowAll();
        }
    }
}
