using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class MainStack
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);

            int count = stack.Count;

            while (!stack.IsEmpty())
            {
                int output;
                stack.Pop(out output);
                Console.WriteLine(output);
            }

            Console.Read();
        }
    }
}
