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
            value = _value;
            next = null;
            prev = null;
        }
    }

    public class LinkedList2
    {
        public Node head;
        public Node tail;

        public LinkedList2()
        {
            head = null;
            tail = null;
        }

        public void AddInTail(Node _item)
        {
            if (head == null)
            {
                head = _item;
                head.next = null;
                head.prev = null;
            }
            else
            {
                tail.next = _item;
                _item.prev = tail;
            }
            tail = _item;
        }

        public Node Find(int _value)
        {
            Node node = head;
            while (node != null)
            {
                if (node.value == _value) return node;
                node = node.next;
            }
            return null;
        }

        public List<Node> FindAll(int _value)
        {
            List<Node> nodes = new List<Node>();
            // здесь будет ваш код поиска всех узлов по заданному значению
            Node node = head;
            while (node != null)
            {
                if (node.value == _value) nodes.Add(node);
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

                if (node.value == _value)
                {
                    if (Count() == 1)
                    {
                        head = null;
                        tail = null;
                    }
                    else if (head.value == _value)
                    {
                        nextNode.prev = null;
                        head = nextNode;

                    }
                    else if (tail.value == _value)
                    {
                        prevNode.next = null;
                        tail = prevNode;
                    }
                    else
                    {
                        prevNode.next = nextNode;
                        nextNode.prev = prevNode;
                    }

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
                    if (Count() == 1)
                    {
                        head = null;
                        tail = null;
                    }
                    else if (node == head)
                    {
                        nextNode.prev = null;
                        head = nextNode;
                    }
                    else if (node == tail)
                    {
                        prevNode.next = null;
                        tail = prevNode;
                    }
                    else
                    {
                        prevNode.next = nextNode;
                        nextNode.prev = prevNode;
                    }

                }

                node = node.next;
            }
        }

        public void Clear()
        {
            head = null;
            tail = null;
        }

        public int Count()
        {
            Node node = head;
            int count = 0;

            while (node != null)
            {
                count++;
                node = node.next;
            }

            return count;
        }

        public void InsertAfter(Node _nodeAfter, Node _nodeToInsert)
        {
            Node node = head;

            if (_nodeAfter == null)
            {
                head = _nodeToInsert;
                head.next = node;

                if (node != null)
                {
                    node.prev = _nodeToInsert;
                }

                if (Count() == 1)
                {
                    tail = _nodeToInsert;
                }

                return;
            }


            node = _nodeAfter;
            Node nextNode = node.next;


            if (nextNode == null)
            {
                tail = _nodeToInsert;
            }
            else
            {
                nextNode.prev = _nodeToInsert;
            }

            _nodeToInsert.prev = node;
            _nodeToInsert.next = nextNode;
            node.next = _nodeToInsert;
        }
    }
}