internal class Program
{
    private static void Main(string[] args)
    {
        SingleLinkedList<int> list = new SingleLinkedList<int>();

        list.addFirst(4);
        list.addFirst(2);
        list.addFirst(3);
        list.addFirst(1);
        list.addFirst(5);
        // list.addNodeInPosition(8, 2);
        // list.deleteNode(1);

        list.bubbleSort();
        list.printList();
        // Console.WriteLine(list.inList(1) ? "Value is in the list" : "Value is not in the list");
    }
}
