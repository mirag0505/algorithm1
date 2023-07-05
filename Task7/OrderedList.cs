using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Node<T>
    {
        public T value;
        public Node<T> next, prev;

        public Node(T _value)
        {
            value = _value;
            next = null;
            prev = null;
        }
    }

    public class OrderedList<T>
    {
        public Node<T> head, tail;
        private bool _ascending; //возрастание
        private int _size;

        public OrderedList(bool asc)
        {
            head = null;
            tail = null;
            _ascending = asc;
            _size = 0;
        }

        public int Compare(T v1, T v2)
        {
            if (typeof(T) == typeof(String))
            {
                return string.Compare(v1.ToString().Trim(), v2.ToString().Trim());
            }
            else
            {
                int newV1 = Convert.ToInt32(v1);
                int newV2 = Convert.ToInt32(v2);

                if (newV1 > newV2) return 1;
                if (newV1 < newV2) return -1;
                return 0;
            }
        }

        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (_size == 0)
            {
                head = newNode;
                tail = newNode;
                _size++;

                return;
            }

            Node<T> node = head;

            while (node != null)
            {
                var isAscending = _ascending ? Compare(node.value, value) >= 0 : Compare(node.value, value) <= 0;
                if (isAscending)
                {
                    if (node.prev == null)
                    {
                        node.prev = newNode;
                        newNode.next = node;
                        head = newNode;
                    }
                    else
                    {
                        var firstNode = node.prev;
                        var lastNode = node;

                        firstNode.next = newNode;
                        lastNode.prev = newNode;

                        newNode.next = lastNode;
                        newNode.prev = firstNode;
                    }

                    _size++;
                    break;
                }

                if (node.next == null)
                {
                    node.next = newNode;
                    newNode.prev = node;
                    tail = newNode;
                    _size++;
                    break;
                }

                node = node.next;
            }
        }

        public Node<T> Find(T val)
        {

            Node<T> node = head;
            while (node != null)
            {
                if (_ascending && Compare(head.value, val) > 0) return null;
                if (_ascending && Compare(tail.value, val) < 0) return null;
                if (!_ascending && Compare(head.value, val) < 0) return null;
                if (!_ascending && Compare(tail.value, val) > 0) return null;

                if (Compare(node.value, val) == 0) return node;
                node = node.next;
            }
            return null;
        }

        public void Delete(T val)
        {
            Node<T> node = head;
            while (node != null)
            {

                if (_ascending && Compare(head.value, val) > 0) return;
                if (_ascending && Compare(tail.value, val) < 0) return;
                if (!_ascending && Compare(head.value, val) < 0) return;
                if (!_ascending && Compare(tail.value, val) > 0) return;

                Node<T> prevNode = node.prev;
                Node<T> nextNode = node.next;

                if (Compare(node.value, val) == 0)
                {
                    if (_size == 1)
                    {
                        head = null;
                        tail = null;
                    }
                    else if (Compare(head.value, val) == 0)
                    {
                        nextNode.prev = null;
                        head = nextNode;
                    }
                    else if (Compare(tail.value, val) == 0)
                    {
                        prevNode.next = null;
                        tail = prevNode;
                    }
                    else
                    {
                        prevNode.next = nextNode;
                        nextNode.prev = prevNode;
                    }

                    _size--;
                    return;
                };

                node = node.next;
            }
        }

        public void Clear(bool asc)
        {
            _ascending = asc;
            head = null;
            tail = null;
            _size = 0;
        }

        public int Count()
        {
            return _size; // здесь будет ваш код подсчёта количества элементов в списке
        }

        List<Node<T>> GetAll()
        {
            List<Node<T>> r = new List<Node<T>>();
            Node<T> node = head;
            while (node != null)
            {
                r.Add(node);
                node = node.next;
            }
            return r;
        }

        public string GetStringListsValue()
        {
            List<string> list = new List<string>();
            Node<T> node = head;
            while (node != null)
            {
                list.Add(node.value.ToString());
                node = node.next;
            }

            return String.Join(",", list);
        }
    }

}