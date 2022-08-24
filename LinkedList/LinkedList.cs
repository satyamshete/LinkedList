using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList
    {
        public Node Head;
        public Node Tail;

        public LinkedList()
        {
            Head = null;
            Tail = null;
        }
        public void AddNodeAtLast(int Data) 
        {
            Node node = new Node(Data);
            if (this.Head == null)
            {
                this.Head = node;
                this.Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
            Console.WriteLine("{0} is Added ", Data);
        }
        public void DisplayNode()
        {
            if (this.Head == null)
            {
                Console.WriteLine("No elements present ");
            }
            else
            {
                Console.WriteLine("Elements present are: ");
                Node temp = Head;

                while (temp != null)
                {
                    Console.Write(temp.Data + " ");
                    temp = temp.Next;

                }


            }
            Console.WriteLine();
        }
        public void AddNodeAtFirst(int data)
        {
            Node node = new Node(data);
            node.Next = Head;
            Head = node;
            if (Tail == null)
            {
                Tail = node;
            }

            Console.WriteLine("{0} is Added ", data);
        }
        public void AddInBetween(int data)
        {
            Console.WriteLine("Enter Previous element");
            int previous = int.Parse(Console.ReadLine());
            Node node = new Node(data);
            Node temp = Head;
            if (Head == null)
            {
                Console.WriteLine("No elements present in ");
            }
            else
            {
                int Count = 0;
                while (temp != null)
                {
                    if (temp.Data == previous && Tail.Data != previous)
                    {
                        Count++;
                        node.Next = temp.Next;
                        temp.Next = node;
                        Console.WriteLine("{0} Element added ", data);
                        break;
                    }
                    if (Tail.Data == previous)
                    {
                        AddNodeAtLast(data);
                        break;
                    }
                    temp = temp.Next;
                }
                if (Count == 0)
                {

                    Console.WriteLine("{0} Element is not added ", data);
                }


            }

        }
        public void DeleteFirstelement()
        {
            if (this.Head == null)
            {
                Console.WriteLine("No elements present ");
            }
            else
            {
                Head = Head.Next;
                Console.WriteLine("Deleted the first element");
            }

        }
        public void DeleteLastElement()
        {
            if (this.Head == null)
            {
                Console.WriteLine("No elements present ");
            }
            else
            {
                Node temp = Head;
                while (temp.Next.Next != Tail)
                {
                    temp = temp.Next;
                }
                Tail = temp.Next;
                temp = temp.Next;
                temp.Next = null;

            }

        }
        public void SearchNode(int data)
        {
           
            Node temp = Head;
            int Count = 0;
            while (temp != null)
            {
                if (temp.Data == data)
                {
                    Count++;
                    Console.WriteLine("{0} Elements is present ", data);
                    break;
                }
                temp = temp.Next;
            }
            if (Count == 0)
            {
                Console.WriteLine("{0} Elements is not present ", data);
            }

        }
        public void DeleteInBetween(int data)
        {
            if (Head == null)
            {
                Console.WriteLine("No elements present ");
            }
            else
            {
                Node temp = Head;
                while (temp != null)
                {
                    if (temp.Next.Data == data)
                    {
                        temp.Next = temp.Next.Next;
                        Console.WriteLine("{0} Node deleted", data);
                        break;
                    }
                    temp = temp.Next;

                }
            }
        }
    }
}
