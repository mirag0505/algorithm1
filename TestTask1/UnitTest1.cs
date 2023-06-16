using AlgorithmsDataStructures;

namespace TestTask1;

public class UnitTest1
{
    [Fact]
    public void CreatedNode_Test()
    {
        // Arrange
        var list = new LinkedList();
        var node = new Node(5);

        // Act
        list.AddInTail(node);

        // Assert
        Assert.Equal(node, list.tail);
        Assert.Equal(node, list.head);
    }

    [Fact]
    public void AddInTail_Test()
    {
        // Arrange
        var list = new LinkedList();
        var node1 = new Node(1);
        var node2 = new Node(2);
        var node3 = new Node(3);

        list.AddInTail(node1);
        Assert.Equal(node1, list.head);
        Assert.Equal(node1, list.tail);

        list.AddInTail(node2);
        Assert.Equal(node1, list.head);
        Assert.Equal(node2, list.tail);

        list.AddInTail(node3);
        Assert.Equal(node1, list.head);
        Assert.Equal(node3, list.tail);
    }

    [Fact]
    public void Find_Test()
    {
        var list = new LinkedList();
        var node1 = new Node(1);
        var node2 = new Node(2);
        var node3 = new Node(3);
        var node4 = new Node(4);

        // Act
        list.AddInTail(node1);
        list.AddInTail(node2);
        list.AddInTail(node3);
        list.AddInTail(node4);

        var findedNode1 = list.Find(2);
        var findedNode2 = list.Find(3);

        // Assert
        Assert.Equal(findedNode1.value, 2);
        Assert.Equal(findedNode2.value, 3);
    }

    [Fact]
    public void Find_Test_empty_list()
    {
        var list = new LinkedList();

        // Act
        var findedNode1 = list.Find(2);
        var findedNode2 = list.Find(3);

        // Assert
        Assert.Null(findedNode1);
        Assert.Null(findedNode2);
    }

    [Fact]
    public void Count_Test()
    {
        var list = new LinkedList();
        var list2 = new LinkedList();
        var node1 = new Node(1);
        var node2 = new Node(2);
        var node3 = new Node(3);
        var node4 = new Node(4);

        // Act
        list.AddInTail(node1);
        list.AddInTail(node2);

        var lengthList1 = list.Count();

        list.AddInTail(node3);
        list.AddInTail(node4);

        var lengthList2 = list.Count();
        var lengthList3 = list2.Count();

        // Assert
        Assert.Equal(lengthList1, 2);
        Assert.Equal(lengthList2, 4);
        Assert.Equal(lengthList3, 0);
    }

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
    public void Remove_Test_head()
    {

        var list1 = new LinkedList();
        var list2 = new LinkedList();

        var node1 = new Node(1);
        var node2 = new Node(2);
        var node3 = new Node(3);
        var node4 = new Node(4);

        var node12 = new Node(2);
        var node13 = new Node(3);
        var node14 = new Node(4);

        // Act
        list1.AddInTail(node1);
        list1.AddInTail(node2);
        list1.AddInTail(node3);
        list1.AddInTail(node4);

        list2.AddInTail(node12);
        list2.AddInTail(node13);
        list2.AddInTail(node14);

        // Assert
        bool result = list1.Remove(1);
        Assert.True(result);
        Assert.Null(list1.Find(1));
        Assert.True(AreEqual(list1, list2));

        Assert.Equal(list1.head, node2);
        Assert.Equal(list1.tail, node4);
    }
    [Fact]
    public void Remove_Test_empty_list()
    {
        var list1 = new LinkedList();
        var list2 = new LinkedList();

        // Assert
        bool result = list1.Remove(1);
        Assert.False(result);
        Assert.Null(list1.Find(1));
        Assert.True(AreEqual(list1, list2));
    }
    [Fact]
    public void Remove_Test_one_node()
    {
        var list1 = new LinkedList();
        var list2 = new LinkedList();

        var node1 = new Node(1);

        // Act

        list1.AddInTail(node1);
        // Assert
        bool result = list1.Remove(1);
        Assert.True(result);
        Assert.Null(list1.Find(1));
        Assert.True(AreEqual(list1, list2));

        Assert.Null(list1.head);
        Assert.Null(list1.tail);
    }

    [Fact]
    public void Remove_Test_one_node_stayed_last()
    {
        var list1 = new LinkedList();
        var list2 = new LinkedList();

        var node1 = new Node(1);
        var node2 = new Node(2);

        var node11 = new Node(1);
        // Act

        list1.AddInTail(node1);
        list1.AddInTail(node2);

        list2.AddInTail(node11);

        // Assert
        bool result = list1.Remove(2);
        Assert.True(result);
        Assert.Null(list1.Find(2));
        Assert.True(AreEqual(list1, list2));

        Assert.Equal(list1.head, node1);
        Assert.Equal(list1.tail, node1);
    }

    [Fact]
    public void Remove_Test_one_node_stayed_first()
    {
        var list1 = new LinkedList();
        var list2 = new LinkedList();

        var node1 = new Node(1);
        var node2 = new Node(2);

        var node11 = new Node(1);
        var node12 = new Node(2);
        // Act

        list1.AddInTail(node1);
        list1.AddInTail(node2);

        list2.AddInTail(node12);
        // Assert
        bool result = list1.Remove(1);
        Assert.True(result);
        Assert.Null(list1.Find(1));
        Assert.True(AreEqual(list1, list2));

        Assert.Equal(list1.head, node2);
        Assert.Equal(list1.tail, node2);
    }

    [Fact]
    public void Remove_Test_tail()
    {
        var list1 = new LinkedList();
        var list2 = new LinkedList();

        var node1 = new Node(1);
        var node2 = new Node(2);
        var node3 = new Node(3);
        var node4 = new Node(4);

        var node11 = new Node(1);
        var node12 = new Node(2);
        var node13 = new Node(3);

        // Act
        list1.AddInTail(node1);
        list1.AddInTail(node2);
        list1.AddInTail(node3);
        list1.AddInTail(node4);

        list2.AddInTail(node11);
        list2.AddInTail(node12);
        list2.AddInTail(node13);

        // Assert
        bool result = list1.Remove(4);
        Assert.True(result);
        Assert.Null(list1.Find(4));
        Assert.True(AreEqual(list1, list2));

        Assert.Equal(list1.head, node1);
        Assert.Equal(list1.tail, node3);
    }

    [Fact]
    public void Remove_Test_general()
    {
        var list1 = new LinkedList();
        var list2 = new LinkedList();

        var node1 = new Node(1);
        var node2 = new Node(2);
        var node3 = new Node(3);
        var node4 = new Node(4);

        var node11 = new Node(1);
        var node13 = new Node(3);
        var node14 = new Node(4);

        // Act
        list1.AddInTail(node1);
        list1.AddInTail(node2);
        list1.AddInTail(node3);
        list1.AddInTail(node4);

        list2.AddInTail(node11);
        list2.AddInTail(node13);
        list2.AddInTail(node14);

        // Assert
        bool result = list1.Remove(2);
        Assert.True(result);
        Assert.Null(list1.Find(2));
        Assert.True(AreEqual(list1, list2));

        Assert.Equal(list1.head, node1);
        Assert.Equal(list1.tail, node4);
    }

    [Fact]
    public void RemoveAll_Test()
    {
        var list1 = new LinkedList();
        var list2 = new LinkedList();

        var node1 = new Node(1);
        var node2 = new Node(2);
        var node3 = new Node(2);
        var node4 = new Node(4);

        var node11 = new Node(1);
        var node14 = new Node(4);

        // Act
        list1.AddInTail(node1);
        list1.AddInTail(node2);
        list1.AddInTail(node3);
        list1.AddInTail(node4);

        list2.AddInTail(node11);
        list2.AddInTail(node14);

        // Assert
        list1.RemoveAll(2);
        Assert.Null(list1.Find(2));
        Assert.True(AreEqual(list1, list2));

        Assert.Equal(list1.head, node1);
        Assert.Equal(list1.tail, node4);
    }

    [Fact]
    public void Remove_Test_general_change_value_head_tail()
    {
        var list1 = new LinkedList();
        var list2 = new LinkedList();

        var node1 = new Node(2);
        var node2 = new Node(1);
        var node3 = new Node(3);
        var node4 = new Node(2);

        var node11 = new Node(1);
        var node13 = new Node(3);

        // Act
        list1.AddInTail(node1);
        list1.AddInTail(node2);
        list1.AddInTail(node3);
        list1.AddInTail(node4);

        list2.AddInTail(node11);
        list2.AddInTail(node13);

        // Assert
        bool result1 = list1.Remove(2);
        Assert.True(result1);
        bool result2 = list1.Remove(2);
        Assert.True(result2);
        Assert.Null(list1.Find(2));
        Assert.True(AreEqual(list1, list2));

        Assert.Equal(list1.head, node2);
        Assert.Equal(list1.tail, node3);
    }

    [Fact]
    public void RemoveAll_Test_1()
    {
        var list1 = new LinkedList();
        var list2 = new LinkedList();

        var node1 = new Node(1);
        var node2 = new Node(2);
        var node3 = new Node(2);
        var node4 = new Node(4);

        var node11 = new Node(1);
        var node14 = new Node(4);

        // Act
        list1.AddInTail(node1);
        list1.AddInTail(node2);
        list1.AddInTail(node3);
        list1.AddInTail(node4);

        list2.AddInTail(node11);
        list2.AddInTail(node14);

        // Assert
        list1.RemoveAll(2);
        Assert.Null(list1.Find(2));
        Assert.True(AreEqual(list1, list2));

        Assert.Equal(list1.head, node1);
        Assert.Equal(list1.tail, node4);
    }

    [Fact]
    public void RemoveAll_Test_remove_all_list()
    {
        var list1 = new LinkedList();
        var list2 = new LinkedList();

        var node1 = new Node(2);
        var node2 = new Node(2);
        var node3 = new Node(2);
        var node4 = new Node(2);

        // Act
        list1.AddInTail(node1);
        list1.AddInTail(node2);
        list1.AddInTail(node3);
        list1.AddInTail(node4);

        // Assert
        list1.RemoveAll(2);
        Assert.Null(list1.Find(2));
        Assert.True(AreEqual(list1, list2));
        Assert.Null(list1.head);
        Assert.Null(list1.tail);
    }

    [Fact]
    public void Clear_Test()
    {
        var list1 = new LinkedList();
        var list2 = new LinkedList();

        var node1 = new Node(1);
        var node2 = new Node(2);
        var node3 = new Node(3);
        var node4 = new Node(4);

        // Act
        list1.AddInTail(node1);
        list1.AddInTail(node2);
        list1.AddInTail(node3);
        list1.AddInTail(node4);

        // Assert
        list1.Clear();
        Assert.Null(list1.Find(1));
        Assert.Null(list1.Find(2));
        Assert.Null(list1.Find(3));
        Assert.Null(list1.Find(4));
        Assert.True(AreEqual(list1, list2));

        Assert.Null(list1.head);
        Assert.Null(list1.tail);
    }

    [Fact]
    public void InsertAfter_Test_null()
    {
        var list1 = new LinkedList();
        var list2 = new LinkedList();

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
        list1.AddInTail(node2);
        list1.AddInTail(node3);
        list1.AddInTail(node4);

        list2.AddInTail(node11);
        list2.AddInTail(node12);
        list2.AddInTail(node13);
        list2.AddInTail(node14);

        // Assert
        list1.InsertAfter(null, node1);
        Assert.True(AreEqual(list1, list2));

        Assert.Equal(list1.head, node1);
        Assert.Equal(list1.tail, node4);
    }

    [Fact]
    public void InsertAfter_Test_not_null()
    {
        var list1 = new LinkedList();
        var list2 = new LinkedList();

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

        Assert.Equal(list1.head, node1);
        Assert.Equal(list1.tail, node4);
    }

    [Fact]
    public void InsertAfter_Test_not_null_into_end()
    {
        var list1 = new LinkedList();
        var list2 = new LinkedList();

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

        Assert.Equal(list1.head, node1);
        Assert.Equal(list1.tail, node4);
    }

    [Fact]
    public void InsertAfter_Test_null_empty_list()
    {
        var list1 = new LinkedList();
        var list2 = new LinkedList();

        // Act
        var node1 = new Node(1);
        var node11 = new Node(1);

        // Act
        list2.AddInTail(node11);


        // Assert
        list1.InsertAfter(null, node1);
        Assert.True(AreEqual(list1, list2));

        Assert.Equal(list1.head, node1);
        Assert.Equal(list1.tail, node1);
    }
}