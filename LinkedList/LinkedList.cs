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
    }
}
