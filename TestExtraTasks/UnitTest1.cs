namespace TestExtraTasks;
using AlgorithmsDataStructures;
using ExtraTask;

public class UnitTest1
{
    public static bool AreEqual(LinkedList list1, LinkedList list2)
    {
        Node node1 = list1.head;
        Node node2 = list2.head;

        while (node1 != null || node2 != null)
        {
            if (node1 == null || node2 == null)
            {
                return false;
            }

            if (node1.value != node2.value)
            {
                return false;
            }

            node1 = node1.next;
            node2 = node2.next;
        }

        return true;
    }

    [Fact]
    public void Match_Test()
    {
        // Arrange
        var list1 = new LinkedList();
        var list2 = new LinkedList();
        var testList = new LinkedList();

        var node1 = new Node(1);
        var node2 = new Node(2);

        var node3 = new Node(3);
        var node4 = new Node(4);

        var node5 = new Node(5);
        var node6 = new Node(6);

        list1.AddInTail(node1);
        list1.AddInTail(node3);
        list1.AddInTail(node5);

        list2.AddInTail(node2);
        list2.AddInTail(node4);
        list2.AddInTail(node6);

        testList.AddInTail(new Node(3));
        testList.AddInTail(new Node(7));
        testList.AddInTail(new Node(11));

        // Act
        var result = CustomFunctions.SumMatchingElementsInEqualLists(list1, list2);

        // Assert
        Assert.True(AreEqual(result, testList));
        Assert.Equal(3, result.head.value);
        Assert.Equal(11, result.tail.value);
    }

    [Fact]
    public void Match_Test_empty_lists()
    {
        // Arrange
        var list1 = new LinkedList();
        var list2 = new LinkedList();
        var testList = new LinkedList();

        // Act
        var result = CustomFunctions.SumMatchingElementsInEqualLists(list1, list2);

        // Assert
        Assert.True(AreEqual(result, testList));
        Assert.Equal(null, result.head);
        Assert.Equal(null, result.tail);
    }

    [Fact]
    public void Match_Test_other_length_lists()
    {
        // Arrange
        var list1 = new LinkedList();
        var list2 = new LinkedList();

        var node1 = new Node(1);
        var node2 = new Node(2);
        var node3 = new Node(3);

        var node4 = new Node(4);
        var node5 = new Node(5);

        list1.AddInTail(node1);
        list1.AddInTail(node3);
        list1.AddInTail(node5);

        list2.AddInTail(node2);
        list2.AddInTail(node4);

        var result = CustomFunctions.SumMatchingElementsInEqualLists(list1, list2);

        // Assert
        Assert.Null(result.head);
        Assert.Null(result.tail);
    }
}