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

        public bool Remove(int _value)
        {
            // здесь будет ваш код удаления одного узла по заданному значению
            Node node = head;
            Node prevNode = null;
            Node nextNode = node.next;

            while (node != null)
            {
                if (node.value == _value)
                {
                    break;
                }
                prevNode = node;
                node = node.next;
            }


            if (node == null)
            {
                return false;
            }
            else if (node == head)
            {
                head = nextNode;
                return true;
            }
            else if (node == tail)
            {
                prevNode.next = null;
                tail = prevNode;

                return true;
            }
            else
            {
                prevNode.next = nextNode;
                return true;
            }
        }

        public void RemoveAll(int _value)
        {
            // здесь будет ваш код удаления всех узлов по заданному значению
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
        }

    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new();

        Node node1 = new(1);
        Node node2 = new(2);
        Node node3 = new(2);
        Node node4 = new(2);

        list.AddInTail(node1);
        list.AddInTail(node2);
        list.AddInTail(node3);
        list.AddInTail(node4);
        list.AddInTail(new Node(3));

        Node foundNode = list.Find(2);
        List<Node> foundNodes = list.FindAll(2);

        if (foundNode != null)
        {
            for (int i = 0; i < foundNodes.Count; i++)
            {
                Console.WriteLine("Found node at index " + i + " with value: " + foundNodes[i].value);
            }
        }
        else
        {
            Console.WriteLine("No node with the specified value was found.");
        }
    }
}