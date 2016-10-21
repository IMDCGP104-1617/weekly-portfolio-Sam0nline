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
            LinkedList list = new LinkedList();
            list.InsertBeginning(16);
            list.InsertBeginning(32);
            list.InsertBeginning(64);
        }
    }
}
