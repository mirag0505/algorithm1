using System;
using System.Collections.Generic;
using AlgorithmsDataStructures;

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
            List<Node> nodes = new();
            // здесь будет ваш код поиска всех узлов по заданному значению
            Node node = head;
            while (node != null)
            {
                if (node.value == _value) nodes.Add(node);
                node = node.next;
            }

            return nodes;
        }
        public void ShowAllValue()
        {
            // здесь будет ваш код поиска всех узлов по заданному значению
            Node node = head;
            int count = 0;
            while (node != null)
            {
                count++;
                Console.WriteLine("Found node at index " + count + " with value: " + node.value);
                node = node.next;
            }
            Console.WriteLine("Finish + " + head + "= head | tail =" + tail);
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

class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new();

        var node1 = new Node(1);
        var node2 = new Node(2);
        var node5 = new Node(5);
        list.AddInTail(node1);
        list.AddInTail(new Node(3));
        list.AddInTail(new Node(4));
        list.AddInTail(node5);

        list.ShowAllValue();
        list.InsertAfter(node5, node2);
        list.ShowAllValue();
    }
}