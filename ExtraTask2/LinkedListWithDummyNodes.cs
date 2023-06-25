using System;
using System.Collections.Generic;
using AlgorithmsDataStructures;

namespace AlgorithmsDataStructures
{

    public class Node
    {
        public int value;
        public Node next, prev;

        public Node(int _value)
        {

            next = null;
            prev = null;
            value = _value;
        }
    }

    public class DummyNode : Node
    {
        public DummyNode() : base(0) { }
    }

    public class LinkedListWithDummyNodes
    {
        public DummyNode head;
        public int count;

        public LinkedListWithDummyNodes()
        {
            DummyNode dummyNode = new DummyNode();

            head = dummyNode;

            head.next = head;
            head.prev = head;
        }

        public void AddInTail(Node _item)
        {
            _item.next = head;
            _item.prev = head.prev;

            head.prev.next = _item;
            head.prev = _item;

            count++;
        }

        public Node Find(int _value)
        {
            Node node = head.next;
            while (node is not DummyNode)
            {
                if (node.value == _value) return node;
                node = node.next;
            }
            return null;
        }

        public List<Node> FindAll(int _value)
        {
            List<Node> nodes = new List<Node>();

            Node node = head.next;
            while (node is not DummyNode)
            {
                if (node.value == _value) nodes.Add(node);
                node = node.next;
            }

            return nodes;
        }

        public bool Remove(int _value)
        {
            Node node = head.next;
            while (node is not DummyNode)
            {
                Node prevNode = node.prev;
                Node nextNode = node.next;

                if (node.value == _value)
                {
                    prevNode.next = nextNode;
                    nextNode.prev = prevNode;

                    count--;
                    return true;
                };

                node = node.next;
            }

            return false;
        }

        public void RemoveAll(int _value)
        {
            Node node = head.next;
            while (node is not DummyNode)
            {
                Node prevNode = node.prev;
                Node nextNode = node.next;

                if (node.value == _value)
                {
                    prevNode.next = nextNode;
                    nextNode.prev = prevNode;
                    count--;
                }

                node = node.next;
            }
        }

        public void Clear()
        {
            head.next = head;
            head.prev = head;
            count = 0;
        }

        public int Count()
        {
            return count;
        }

        public void InsertAfter(Node _nodeAfter, Node _nodeToInsert)
        {
            if (_nodeAfter == null)
            {
                _nodeToInsert.prev = head;
                _nodeToInsert.next = head.next;

                head.next.prev = _nodeToInsert;
                head.next = _nodeToInsert;

                count++;

                return;
            }

            _nodeToInsert.prev = _nodeAfter;
            _nodeToInsert.next = _nodeAfter.next;
            _nodeAfter.next.prev = _nodeToInsert;
            _nodeAfter.next = _nodeToInsert;
            count++;
        }
    }
}