using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD10
{
    ///immutable DT
    public class Point
    {
        //int x;
        //int y;
        //public int X { get { return x; } }
        //public int Y { get { return y; } }

        public int X { get; init; }
        public int Y { get; init; }

        public Point()
        {
            X = 22;
            Y = 33;
        }

        public Point(int _x,int _y)
        {
            X = _x;
            Y = _y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

    }
}
