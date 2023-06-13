using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Node
    {
        public int value;
        public Node next;
        public Node(int _value) { value = _value; }
    }

    public class LinkedList
    {
        public Node head;
        public Node tail;

        public LinkedList()
        {
            head = null;
            tail = null;
        }

        public void AddInTail(Node _item)
        {
            if (head == null) head = _item;
            else tail.next = _item;
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
            // здесь будет ваш код удаления одного узла по заданному значению
            Node node = head;
            Node prevNode = null;

            while (node != null)
            {
                if (node.value == _value)
                {
                    if (node == head)
                    {
                        head = node.next;
                        int lengthList = Count();
                        if (lengthList == 0)
                        {
                            tail = null;
                        }
                    }
                    else if (node == tail)
                    {
                        prevNode.next = null;
                        tail = prevNode;
                    }
                    else
                    {
                        prevNode.next = node.next;
                    }

                    return true;
                }
                prevNode = node;
                node = node.next;
            }
            return false;
        }

        public void RemoveAll(int _value)
        {
            Node node = head;
            Node prevNode = null;

            while (node != null)
            {
                if (node.value == _value)
                {
                    if (node == head)
                    {
                        head = node.next;
                        tail = node.next;
                    }
                    else if (node == tail)
                    {
                        prevNode.next = null;
                        tail = prevNode;
                    }
                    else
                    {
                        prevNode.next = node.next;
                    }
                }
                else
                {
                    prevNode = node;
                }
                node = node.next;
            }

        }

        public void Clear()
        {
            // здесь будет ваш код очистки всего списка
            head = null;
            tail = null;
        }

        public int Count()
        {
            // здесь будет ваш код подсчёта количества элементов в списке
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
            // здесь будет ваш код вставки узла после заданного

            // если _nodeAfter = null , 
            // добавьте новый элемент первым в списке
            Node node = head;

            if (_nodeAfter == null)
            {
                head = _nodeToInsert;
                head.next = node;

                int lengthList = Count();
                if (lengthList == 1)
                {
                    tail = _nodeToInsert;
                }
            }
            else
            {
                while (node != null)
                {
                    if (node == _nodeAfter)
                    {
                        _nodeToInsert.next = node.next;
                        if (node.next == null)
                        {
                            tail = _nodeToInsert;
                        }
                        node.next = _nodeToInsert;

                        break;
                    }
                    node = node.next;
                }
            }
        }

    }
}