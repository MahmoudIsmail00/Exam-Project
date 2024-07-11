using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD10
{
    class Kamal:List<int>
    {
        public void Add(int item) 
        {
            //add functionality
            Console.WriteLine($"DONEEEE {item} is Added in file");
            //REMEMBER KEEP OLD BEHAVIOR
            base.Add(item);
        }
    }

    class MyList<T> : List<T> 
    {
        public void Add(T item)
        {

        }
    }
}
