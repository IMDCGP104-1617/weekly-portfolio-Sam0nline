using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Stack
    {
        
        Object[] stack;
        Int32 i;
        Int32 j;
        

        public Stack(int n)
        {
            stack = new Object[n];
            i = 0;
            j = n;
        }

        public void Push(object item)
        {
            if (isEmpty())
            {
                stack[i++] = item;
            }
            else
                Console.WriteLine("Stack is Full");
        }

        public bool isEmpty()
        {
            if (j == i)
                return true;
            else
                return false;
        }

        public void Peek()
        {
            if (i == 0)
                Console.WriteLine("0");
            else
                Console.Write("");
        }
    }
}
