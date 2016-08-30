using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures
{
    public class MySingleLinkedList<T>
    {
        public int size;
        private Node head;
        private Node current;

        private class Node
        {
            public object element;
            public Node next;

            public Node(T e)
            {
                element = e;
                next = null;
            }

        }

        public MySingleLinkedList()
        {
            size = 0;
            head = null;
        }

        //Add nodes to the tail.
        public void add(T element)
        {
            Node newNode = new Node(element);
            size++;

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                current.next = newNode;
            }

            current = newNode;

        }

        //Get element at position i
        //1 based
        public T get(int i)
        {
            Node tempNode = head;

            if (i > size || i <= 0)
            {
                throw new ArgumentOutOfRangeException(string.Format("Postition: {0}, Size: {1}",i,size));
            }

            for (int x = 1; x < i; x++)
            {
                tempNode = tempNode.next;
            }

            return (T)tempNode.element;
        }

        //Delete element at position i
        //1 based
        public void delete(int i)
        {
            Node tempNode = head;

            if (i > size || i <= 0)
            {
                throw new ArgumentOutOfRangeException(string.Format("Postition: {0}, Size: {1}", i + 1, size));
            }

            if (i == 1)
            {
                head = head.next;
                size--;
            }
            else
            {
                //GET NODE BEFORE THE DELETE NODE
                for (int x = 1; x < i - 1; x++)
                {
                    tempNode = tempNode.next;
                }

                if (tempNode.next.next != null)
                {
                    tempNode.next = tempNode.next.next;
                }
                else
                {
                    tempNode.next = null;
                }
                size--;
            }

            
        }
        
    }
}
