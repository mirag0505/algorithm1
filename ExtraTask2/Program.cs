using AlgorithmsDataStructures;

class Program
{
    static void Main(string[] args)
    {
        var list1 = new LinkedListWithDummyNodes();

        var node1 = new Node(1);
        var node2 = new Node(2);
        var node3 = new Node(3);

        list1.AddInTail(node2);
        list1.AddInTail(node3);
        list1.InsertAfter(null, node1);
    }
}