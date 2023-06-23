using AlgorithmsDataStructures;
namespace TestExtraTasks2;
public class UnitTest
{
    public static bool AreEqual(LinkedListWithDummyNodes list1, LinkedListWithDummyNodes list2)
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
    public void CreatedLinkedList()
    {
        var list = new LinkedListWithDummyNodes();

        Assert.Equal(list.head.next, list.tail);
        Assert.Equal(list.tail.prev, list.head);

        Assert.True(list.head.isDummy);
        Assert.True(list.tail.isDummy);
    }

    [Fact]
    public void CreatedNodeNotDummy()
    {
        var list = new LinkedListWithDummyNodes();

        Assert.Equal(list.head.next, list.tail);
        Assert.Equal(list.tail.prev, list.head);

        var node = new Node(5);

        Assert.False(node.isDummy);
    }

    [Fact]
    public void AddInTail_Test()
    {
        // Arrange
        var list = new LinkedListWithDummyNodes();
        var node1 = new Node(1);
        var node2 = new Node(2);

        list.AddInTail(node1);
        Assert.Equal(list.head.next, node1);
        Assert.Equal(list.tail.prev, node1);

        list.AddInTail(node2);
        Assert.Equal(list.head.next, node1);
        Assert.Equal(list.tail.prev, node2);

        Assert.Equal(node1.next, node2);
        Assert.Equal(node2.prev, node1);
    }

    [Fact]
    public void Find_Test()
    {
        var list = new LinkedListWithDummyNodes();

        // Act
        list.AddInTail(new Node(1));
        list.AddInTail(new Node(2));
        list.AddInTail(new Node(3));
        list.AddInTail(new Node(4));

        var findedNode1 = list.Find(2);
        var findedNode2 = list.Find(3);

        // Assert
        Assert.Equal(2, findedNode1.value);
        Assert.Equal(3, findedNode2.value);
    }

    [Fact]
    public void Find_Test_without_finded_element()
    {
        var list = new LinkedListWithDummyNodes();

        // Act
        list.AddInTail(new Node(1));
        list.AddInTail(new Node(2));
        list.AddInTail(new Node(3));
        list.AddInTail(new Node(4));

        var findedNode1 = list.Find(6);
        var findedNode2 = list.Find(0);

        // Assert
        Assert.Null(findedNode1);
        Assert.Null(findedNode2);
    }

    [Fact]
    public void Count_Test()
    {
        var list = new LinkedListWithDummyNodes();
        var list2 = new LinkedListWithDummyNodes();

        // Act
        list.AddInTail(new Node(1));
        list.AddInTail(new Node(2));

        var lengthList1 = list.Count();

        list.AddInTail(new Node(3));
        list.AddInTail(new Node(4));

        var lengthList2 = list.Count();
        var lengthList3 = list2.Count();

        // Assert
        Assert.Equal(2, lengthList1);
        Assert.Equal(4, lengthList2);
        Assert.Equal(0, lengthList3);
    }

    [Fact]
    public void Remove_Test_empty_list()
    {
        var list1 = new LinkedListWithDummyNodes();
        var list2 = new LinkedListWithDummyNodes();

        // Assert
        bool result = list1.Remove(1);
        Assert.False(result);
        Assert.Null(list1.Find(1));
        Assert.True(AreEqual(list1, list2));
    }

    [Fact]
    public void Remove_Test_with_one_element_into_list()
    {
        var list1 = new LinkedListWithDummyNodes();
        var list2 = new LinkedListWithDummyNodes();

        var node1 = new Node(1);
        list1.AddInTail(node1);

        // Assert
        bool result = list1.Remove(1);
        Assert.True(result);
        Assert.Null(list1.Find(1));

        Assert.True(AreEqual(list1, list2));
    }

    [Fact]
    public void Remove_first_elsement_from_two_element_into_list()
    {
        var list1 = new LinkedListWithDummyNodes();
        var list2 = new LinkedListWithDummyNodes();

        var node1 = new Node(1);
        var node2 = new Node(2);
        list1.AddInTail(node1);
        list1.AddInTail(node2);
        list2.AddInTail(new Node(2));

        // Assert
        bool result = list1.Remove(1);
        Assert.True(result);
        Assert.Null(list1.Find(1));
        Assert.Equal(node2.prev.isDummy, true);
        Assert.Equal(node2.next.isDummy, true);
        Assert.Equal(node2.value, 2);

        Assert.True(AreEqual(list1, list2));
    }

    [Fact]
    public void Remove_second_element_from_two_element_into_list()
    {
        var list1 = new LinkedListWithDummyNodes();
        var list2 = new LinkedListWithDummyNodes();

        Node node1 = new Node(1);
        Node node2 = new Node(2);
        list1.AddInTail(node1);
        list1.AddInTail(node2);
        list2.AddInTail(new Node(1));

        // Assert
        bool result = list1.Remove(2);
        Assert.True(result);
        Assert.Null(list1.Find(2));

        Assert.Equal(node1.value, 1);

        Assert.True(AreEqual(list1, list2));
    }

    [Fact]
    public void Remove_middle_element_from_three_element_into_list()
    {
        var list1 = new LinkedListWithDummyNodes();
        var list2 = new LinkedListWithDummyNodes();

        Node node1 = new Node(1);
        Node node2 = new Node(2);
        Node node3 = new Node(3);
        list1.AddInTail(node1);
        list1.AddInTail(node2);
        list1.AddInTail(node3);
        list2.AddInTail(new Node(1));
        list2.AddInTail(new Node(3));

        // Assert
        bool result = list1.Remove(2);
        Assert.True(result);
        Assert.Null(list1.Find(2));

        Assert.Equal(list1.head, node1.prev);
        Assert.Equal(node1.next, node3);
        Assert.Equal(1, node1.value);

        Assert.Equal(node3.prev, node1);
        Assert.Equal(list1.tail, node3.next);
        Assert.Equal(3, node3.value);

        Assert.True(AreEqual(list1, list2));
    }

    [Fact]
    public void RemoveAll_Test_empty_list()
    {
        var list1 = new LinkedListWithDummyNodes();
        var list2 = new LinkedListWithDummyNodes();

        // Assert
        list1.RemoveAll(1);
        Assert.Null(list1.Find(1));
        Assert.True(AreEqual(list1, list2));
    }

    [Fact]
    public void RemoveAll_Test_without_match()
    {
        var list1 = new LinkedListWithDummyNodes();
        var list2 = new LinkedListWithDummyNodes();

        Node node1 = new Node(1);
        Node node3 = new Node(3);

        list1.AddInTail(node1);
        list1.AddInTail(new Node(2));
        list1.AddInTail(new Node(2));
        list1.AddInTail(node3);

        list2.AddInTail(new Node(1));
        list2.AddInTail(new Node(2));
        list2.AddInTail(new Node(2));
        list2.AddInTail(new Node(3));

        // Assert
        list1.RemoveAll(4);
        Assert.Null(list1.Find(4));
        Assert.Equal(list1.head.next, node1);
        Assert.Equal(list1.tail.prev, node3);
        Assert.True(AreEqual(list1, list2));
    }

    [Fact]
    public void RemoveAll_Test_mach_every_elements()
    {
        var list1 = new LinkedListWithDummyNodes();
        var list2 = new LinkedListWithDummyNodes();

        Node node1 = new Node(1);
        Node node2 = new Node(1);

        list1.AddInTail(node1);
        list1.AddInTail(node2);

        // Assert
        list1.RemoveAll(1);
        Assert.Null(list1.Find(1));
        Assert.Equal(list1.head.next, list1.tail);
        Assert.Equal(list1.tail.prev, list1.head);

        Assert.True(AreEqual(list1, list2));
    }

    [Fact]
    public void Clear()
    {
        var list1 = new LinkedListWithDummyNodes();
        var list2 = new LinkedListWithDummyNodes();

        Node node1 = new Node(1);
        Node node2 = new Node(1);

        list1.AddInTail(node1);
        list1.AddInTail(node2);

        list1.Clear();

        Assert.Null(list1.Find(1));
        Assert.Equal(list1.head.next, list1.tail);
        Assert.Equal(list1.tail.prev, list1.head);
        Assert.Equal(0, list1.count);

        Assert.True(AreEqual(list1, list2));
    }

    [Fact]
    public void RemoveAll_remove_corner_elements()
    {
        var list1 = new LinkedListWithDummyNodes();
        var list2 = new LinkedListWithDummyNodes();

        Node node2 = new Node(2);
        Node node3 = new Node(3);

        list1.AddInTail(new Node(1));
        list1.AddInTail(node2);
        list1.AddInTail(node3);
        list1.AddInTail(new Node(1));

        list2.AddInTail(new Node(2));
        list2.AddInTail(new Node(3));

        // Assert
        list1.RemoveAll(1);
        Assert.Null(list1.Find(1));
        Assert.Equal(list1.head.next, node2);
        Assert.Equal(list1.tail.prev, node3);

        Assert.Equal(node2.next, node3);
        Assert.Equal(node2.value, 2);

        Assert.Equal(node3.prev, node2);
        Assert.Equal(node3.value, 3);

        Assert.True(AreEqual(list1, list2));
    }

    [Fact]
    public void RemoveAll_middle_elements()
    {
        var list1 = new LinkedListWithDummyNodes();
        var list2 = new LinkedListWithDummyNodes();

        Node node1 = new Node(1);
        Node node2 = new Node(2);
        Node node3 = new Node(2);
        Node node4 = new Node(3);

        list1.AddInTail(node1);
        list1.AddInTail(node2);
        list1.AddInTail(node3);
        list1.AddInTail(node4);

        list2.AddInTail(new Node(1));
        list2.AddInTail(new Node(3));

        // Assert
        list1.RemoveAll(2);
        Assert.Null(list1.Find(2));
        Assert.Equal(node1.prev, list1.head);
        Assert.Equal(node1.next, node4);
        Assert.Equal(node1.value, 1);

        Assert.Equal(node4.prev, node1);
        Assert.Equal(node4.next, list1.tail);
        Assert.Equal(node4.value, 3);

        Assert.True(AreEqual(list1, list2));
    }

    [Fact]
    public void InsertAfter_Test_null()
    {
        var list1 = new LinkedListWithDummyNodes();
        var list2 = new LinkedListWithDummyNodes();

        // Act
        var node1 = new Node(1);
        var node2 = new Node(2);
        var node3 = new Node(3);

        var node11 = new Node(1);
        var node12 = new Node(2);
        var node13 = new Node(3);

        // Act
        list1.AddInTail(node2);
        list1.AddInTail(node3);

        list2.AddInTail(node11);
        list2.AddInTail(node12);
        list2.AddInTail(node13);

        // Assert
        list1.InsertAfter(null, node1);
        // Assert.True(AreEqual(list1, list2));

        Assert.Equal(list1.head.next, node1);
        Assert.Equal(list1.tail.prev, node3);

        Assert.Equal(node1.next, node2);

        Assert.Equal(node2.next, node3);
        Assert.Equal(node2.prev, node1);

        Assert.Equal(node3.prev, node2);

    }

    [Fact]
    public void InsertAfter_Test_not_null()
    {
        var list1 = new LinkedListWithDummyNodes();
        var list2 = new LinkedListWithDummyNodes();

        // Act
        var node1 = new Node(1);
        var node2 = new Node(2);
        var node3 = new Node(3);
        var node4 = new Node(4);

        var node11 = new Node(1);
        var node12 = new Node(2);
        var node13 = new Node(3);
        var node14 = new Node(4);

        // Act
        list1.AddInTail(node1);
        list1.AddInTail(node3);
        list1.AddInTail(node4);

        list2.AddInTail(node11);
        list2.AddInTail(node12);
        list2.AddInTail(node13);
        list2.AddInTail(node14);

        // Assert
        list1.InsertAfter(node1, node2);
        Assert.True(AreEqual(list1, list2));

        Assert.Equal(list1.head.next, node1);
        Assert.Equal(list1.tail.prev, node4);

        Assert.Equal(node1.next, node2);
        Assert.Equal(node1.prev, list1.head);

        Assert.Equal(node2.next, node3);
        Assert.Equal(node2.prev, node1);

        Assert.Equal(node3.next, node4);
        Assert.Equal(node3.prev, node2);

        Assert.Equal(node4.next, list1.tail);
        Assert.Equal(node4.prev, node3);
    }

    [Fact]
    public void InsertAfter_Test_not_null_into_end()
    {
        var list1 = new LinkedListWithDummyNodes();
        var list2 = new LinkedListWithDummyNodes();

        // Act
        var node1 = new Node(1);
        var node2 = new Node(2);
        var node3 = new Node(3);
        var node4 = new Node(4);

        var node11 = new Node(1);
        var node12 = new Node(2);
        var node13 = new Node(3);
        var node14 = new Node(4);

        // Act
        list1.AddInTail(node1);
        list1.AddInTail(node2);
        list1.AddInTail(node3);

        list2.AddInTail(node11);
        list2.AddInTail(node12);
        list2.AddInTail(node13);
        list2.AddInTail(node14);

        // Assert
        list1.InsertAfter(node3, node4);
        Assert.True(AreEqual(list1, list2));

        Assert.Equal(list1.head.next, node1);
        Assert.Equal(list1.tail.prev, node4);

        Assert.Equal(node3.next, node4);
        Assert.Equal(node3.prev, node2);

        Assert.Equal(node4.prev, node3);
    }

    [Fact]
    public void InsertAfter_Test_null_empty_list()
    {
        var list1 = new LinkedListWithDummyNodes();
        var list2 = new LinkedListWithDummyNodes();

        // Act
        var node1 = new Node(1);
        var node11 = new Node(1);

        // Act
        list2.AddInTail(node11);

        // Assert
        list1.InsertAfter(null, node1);
        Assert.True(AreEqual(list1, list2));


        Assert.Equal(node1.next, list1.tail);
        Assert.Equal(node1.prev, list1.head);
    }
}