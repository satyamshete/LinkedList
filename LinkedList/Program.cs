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
                default:
                    Console.WriteLine("Make proper selection");
                    break;
            }
        }
    }
}