using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD10
{
    //generic constraints
    //1- primary constraint  class,struct
    //     0..1
    // special primary constraint [specific DT] ->childs
    //2- secondary constraint
    //    0..M
    //3- new()   default ctor
    //   0..1
    //////////
    class MyStack<T> //where T :new()
    {
        T[] arr;
        int size;
        int tos;
        public MyStack()
        {
            size = 5;
            tos = 0;
            arr = new T[size];
        }
        public MyStack(int _size)
        {
            size = _size;
            tos = 0;
            arr = new T[size];
        }

        #region stack functions
        public void Push(T value)
        {
            //if (tos != size)
            if (!IsFull())
            {
                arr[tos] = value;
                tos++;
            }
            else
            {
                Console.WriteLine("FULL!!!!");
            }
        }
        public T Pop()
        {
            T retVal = default;
            if (!this.IsEmpty())
            {
                tos--;
                retVal = arr[tos];
                //return retVal;
            }
            else
            {
                Console.WriteLine("EMPTY!!!!");
                //return -1; //not effective
                //throw runtime error
            }
            return retVal;
        }

        public bool IsFull()
        {
            return tos == size;
        }
        public bool IsEmpty()
        {
            return tos == 0;
        }

        //public AMR Peak()
        //{
        //    return arr[tos - 1];
        //}
        #endregion
    }
}
