namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Programes");
            LinkedList linkedList = new LinkedList();
            Console.WriteLine("Press 1 for create a linked List");
            Console.WriteLine("Press 2 for add node at first (Add)");
            Console.WriteLine("Press 3 for add node at last (Append)");
            Console.WriteLine("Press 4 for insert a node ");
            Console.WriteLine("Press 5 for delete node at first  ");
            Console.WriteLine("Press 6 for delete node at last ");
            Console.WriteLine("Press 7 for search a node");
            Console.WriteLine("Press 8 for insert node at specific position ");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    linkedList.AddNodeAtLast(56);
                    linkedList.AddNodeAtLast(30);
                    linkedList.AddNodeAtLast(70);
                    linkedList.DisplayNode();
                    break;
                case 2:
                    linkedList.AddNodeAtFirst(70);
                    linkedList.AddNodeAtFirst(30);
                    linkedList.AddNodeAtFirst(56);
                    linkedList.DisplayNode();
                    break;
                case 3:
                    linkedList.AddNodeAtLast(56);
                    linkedList.AddNodeAtLast(30);
                    linkedList.AddNodeAtLast(70);
                    linkedList.DisplayNode();
                    break;
                case 4:
                    linkedList.AddNodeAtLast(56);
                    linkedList.AddNodeAtLast(70);
                    linkedList.DisplayNode();
                    linkedList.AddInBetween(30);
                    linkedList.DisplayNode();
                    break;
                case 5:
                    linkedList.AddNodeAtLast(56);
                    linkedList.AddNodeAtLast(30);
                    linkedList.AddNodeAtLast(70);
                    linkedList.DisplayNode();
                    linkedList.DeleteFirstelement();
                    linkedList.DisplayNode();
                    break;
                case 6:
                    linkedList.AddNodeAtLast(56);
                    linkedList.AddNodeAtLast(30);
                    linkedList.AddNodeAtLast(70);
                    linkedList.DisplayNode();
                    linkedList.DeleteLastElement();
                    linkedList.DisplayNode();
                    break;
                case 7:
                    linkedList.AddNodeAtLast(56);
                    linkedList.AddNodeAtLast(30);
                    linkedList.AddNodeAtLast(70);
                    linkedList.DisplayNode();
                    linkedList.SearchNode(30);
                    break;
                case 8:
                    linkedList.AddNodeAtLast(56);
                    linkedList.AddNodeAtLast(30);
                    linkedList.AddNodeAtLast(70);
                    linkedList.DisplayNode();
                    Console.WriteLine(" 40 is adding");
                    linkedList.AddInBetween(40);
                    linkedList.DisplayNode();
                    break;
                default:
                    Console.WriteLine("Make proper selection");
                    break;
            }
        }
    }
}