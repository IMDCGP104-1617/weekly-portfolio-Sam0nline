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
            if (!isStackFull())
            {
                stack[i++] = item;
            }
            else
                Console.WriteLine("Stack is Full");
        }

        public bool isStackFull()
        {
            if (i == j)
                return true;
            else
                return false;
        }
    }
}