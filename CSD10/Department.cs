using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD10
{
    public class Department:IComparable
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }

        public Department()
        {
            DeptId = 10;
            DeptName = ".NET";
        }

        public override string ToString()
        {
            return $"{DeptName} department";
        }

        public int CompareTo(object? obj)
        {
            var right= obj as Department;
            return this.DeptName.CompareTo(right.DeptName);
        }
    }
}
