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

        public void Peek()
        {
            if (i == 0)
                Console.WriteLine("0");
            else
                Console.Write("");
        }
    }
}
//This peek method should identify if i is the Top value or the current item