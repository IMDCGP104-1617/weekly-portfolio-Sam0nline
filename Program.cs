using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamzList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.InsertBeginning(3);
            list.InsertAfter(6);
            list.RemoveBeginning();
            list.InsertBeginning(5);
            list.RemoveAfter(2);
        }
    }
}
