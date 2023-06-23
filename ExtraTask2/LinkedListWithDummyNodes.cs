using System;
using System.Collections.Generic;
using AlgorithmsDataStructures;

namespace AlgorithmsDataStructures
{

    public class Node
    {
        public int value;
        public Node next, prev;
        public bool isDummy = false;

        public Node(int? _value)
        {

            next = null;
            prev = null;

            if (_value == null) isDummy = true;
            if (_value != null) value = (int)_value;
        }
    }

    public class LinkedListWithDummyNodes
    {
        public Node head;
        public Node tail;
        public int count;

        public LinkedListWithDummyNodes()
        {
            Node dummyHeadNode = new Node(null);
            Node dummyTailNode = new Node(null);

            head = dummyHeadNode;
            tail = dummyTailNode;

            head.next = dummyTailNode;
            tail.prev = dummyHeadNode;
        }

        public void AddInTail(Node _item)
        {
            _item.next = tail;
            _item.prev = tail.prev;

            tail.prev.next = _item;
            tail.prev = _item;

            count++;
        }

        public Node Find(int _value)
        {
            Node node = head;
            while (node != null)
            {
                if (node.value == _value && node.isDummy == false) return node;
                node = node.next;
            }
            return null;
        }

        public List<Node> FindAll(int _value)
        {
            List<Node> nodes = new List<Node>();
            Node node = head;
            while (node != null)
            {
                if (node.value == _value && node.isDummy == false) nodes.Add(node);
                node = node.next;
            }

            return nodes;
        }

        public bool Remove(int _value)
        {
            Node node = head;
            while (node != null)
            {
                Node prevNode = node.prev;
                Node nextNode = node.next;

                if (node.value == _value && node.isDummy == false)
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
            Node node = head;
            while (node != null)
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
            head.next = tail;
            tail.prev = head;
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