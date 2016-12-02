using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructs
{
    class Queuez<T>
    {
        private LinkedList<T> queue;
        private int count;

        public int Count { get { return count; } }

        public Queuez()
        {
            queue = new LinkedList<T>();
        }

        ~Queuez()
        {
            while (!IsEmpty())
            {
                T output;
                DeQueue(out output);
            }
        }

        public void Enqueue(T data)
        {
            count++;
            queue.InsertBeginning(data);
        }

        public bool DeQueue(out T output)
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
            return queue.Head;
        }
    }
}
