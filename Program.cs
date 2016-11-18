using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stackz
{
    class Stack<T>
    {
//Each stack element is considered a plate in context with 'stacks'.
        public class Plate
        {
            public T data;
            public Plate Above;
        }
//Base can be considered the 'head' of the stack.
        private Plate Base;

        public Stack()
        {
            Base = null;
        }

        public void CreateStack(T data)
        {
            Plate bottomPlate = new Plate { Data = data };

            if (Base == null)
            {
                Base = bottomPlate;
            }
            else
            {
                bottomPlate.Above = Base;
                Base = bottomPlate;
            }
        }

        public T DestroyStack()
        {
            T ret = default(T);

            if(Base != null)
            {
                ret = Base.data;

                if (Base.Above == null)
                    Base = null;               
            }

            return ret;
        }



    }
}
