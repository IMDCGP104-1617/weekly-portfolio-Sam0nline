using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamzList
{
    class LinkedList<T>
    {
//Node class for linked list, belongs to parent class.
        public class Node
        {
            public T Data;
            public Node Next;
        }

        private Node head;
        private int size;

        public int Size
        {
            get { return size; }
        }
        
        public LinkedList()
        {
            head = null;
        }
//A shorthand version { Data = data }; defines return object types neater.
        public void InsertBeginning(T data)
        {
            Node firstNode = new Node { Data = data };

            if (head == null)
            {
                head = firstNode;
            }
            else
            {
                firstNode.Next = head;
                head = firstNode;
            }

            size++;
        }
//T ret returns a type value if head is not null.
        public T RemoveBeginning()
        {
            T ret = default(T);

            if (head != null)
            {
                ret = head.Data;

                if (head.Next == null)
                    head = null;
                else
                    head = head.Next;

                size--;
            }

            return ret;
        }
//One if statement defines current has something stored, it should be used.
        public void InsertAfter(int count)
        {
            Node firstNode = new Node { Data = data };
            Node current = head;
            int counter = 0;

            while(current != null || current.Next == null)
            {
                if (counter == count)
                {
                    if (current.Next != null)
                        firstNode.Next = current.Next;
//Break statement jumps out of the loop but unlike return it will not step out of the function.
                    current.Next = firstNode;
                    size++;
                    break;
                }

                current = current.Next;
                counter++;
            }
        }
//Current null checks confirm whether data exists after a node that requires a removal.
        public T RemoveAfter(int count)
        {
           T ret = default(T);

            Node current = head;
            int counter = 0;

            while (current != null)
            {
                if (counter == count)
                {
                    if (current.Next != null)
                    {
                        ret = current.Next.Data;
                        current.Next = current.Next.Next;
                    }
                    size--;
                    break;
                }

                current = current.Next;
                counter++;
            }
        }
    }
}

