using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node
    {
        internal int Data;
        internal Node Next;

        public Node(int data)
        {
            this.Data = data;
            Next = null;
        }

    }
}
