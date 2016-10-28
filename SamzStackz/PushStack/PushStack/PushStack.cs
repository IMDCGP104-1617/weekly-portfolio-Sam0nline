using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushStack
{
    class Stack
    {
        public static void Main()
        {
            Stack<string> numbers = new Stack<string>();
            numbers.Push("1");
            numbers.Push("2");
            numbers.Push("3");
            numbers.Push("4");
            numbers.Push("5");
            numbers.Push("6");

            foreach(string number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
