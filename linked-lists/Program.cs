internal class Program
{
    private static void Main(string[] args)
    {
        SingleLinkedList<int> list = new SingleLinkedList<int>();

        list.addFirst(1);
        list.addFirst(2);
        list.addFirst(3);
        list.addFirst(4);
        list.addNodeInPosition(4, 2);
        list.deleteNode(1);

        list.printList();
        Console.WriteLine(list.inList(1) ? "Value is in the list" : "Value is not in the list");
    }
}