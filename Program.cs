using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Stack<T>
    {
        private LinkedList<T> stack;
        private int count;

        public int Count {  get { return count; } }

        public Stack()
        {
            stack = new LinkedList<T>();
        }

        ~Stack()
        {
            while (!IsEmpty())
            {
                T output;
                Pop(out output);
            }
        }

        public void Push(T data)
        {
            count++;
            stack.InsertBeginning(data);
        }

        public bool Pop(out T output)
        {

            output = default(T);

            if (IsEmpty())
            {
                return false;
            }
            count--;
            return true;
                
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public T Peek()
        {
            return stack.Head;
        }
    }
}


//