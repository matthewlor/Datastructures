using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures
{
    public class MyArrayList<T>
    {
        public int size = 0;
        private readonly static int DEFAULT_START_SIZE = 10;
        private object[] elements;

        public MyArrayList()
        {
            elements = new object[DEFAULT_START_SIZE];
        }

        /* 
         * Insertion
         * Best case complexity     = O(1) (Insertion of first item)
         * Worst case complexity    = O(n) (Insertion at the beginning of List means we have to reindex and shift all to the right one)
         * 
         */
        public void add(T o)
        {
            if (size == elements.Length)
            {
                resize();
            }
            elements[size++] = o;
        }

        public void resize()
        {
            int newSize = elements.Length * 2;
            Array.Resize(ref elements, newSize);
            
        }

        /* 
         * Access
         * Complexity = O(1) (Best and worst case)
         * Index makes this instant
         * i is 1 based
         */
        public T get(int i)
        {
            if (i > size || i < 1)
            {
                throw new IndexOutOfRangeException(string.Format("Index: {0}, Size: {1}",i,elements.Length));
            }
            return (T)elements[i-1];
        }

        /* 
         * Deletion
         * Best case complexity     = O(1) (Deletion of last item)
         * Worst case complexity    = O(n) (Delection at the beginning of List means we have to reindex and shift all to the right one)
         * i is 1 based
         */
        public void remove(int i)
        {
            if (i > size || i < 1)
            {
                throw new IndexOutOfRangeException(string.Format("Index: {0}, Size: {1}", i, elements.Length));
            }
            for (int x = i-1; x < elements.Length; x++)
            {
                if (x+1 < elements.Length)
                {
                    elements[x] = elements[x + 1];
                }
            }
            size--;
        }

        /* 
         * Search
         * Complexity   = O(n) 
         * This is usually O(n) because we have to traverse the whole array.
         * 
         */
        public void search(T i)
        {

        }

        /* 
         * Sort
         * Complexity   = O(n) 
         * This is usually O(n) because we have to traverse the whole array.
         * 
         */
        public void sort()
        {

        }
    }
}
