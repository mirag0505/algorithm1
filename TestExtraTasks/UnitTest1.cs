namespace TestExtraTasks;
using AlgorithmsDataStructures;
using ExtraTask;

public class UnitTest1
{
    public bool AreEqual(LinkedList list1, LinkedList list2)
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

        var node5 = new Node(4);
        var node6 = new Node(6);

        // Act
        var result = ExtraTask.CustomFunctions.SumMatchingElementsInEqualLists(list1, list2);

        // Assert
        Assert.True(AreEqual(result, testList));
    }
}