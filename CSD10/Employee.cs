using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD10
{
    public class Employee:IComparable,ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Department Dept { get; set; }

        public Employee() 
        {
            Id = 1;
            Name = "Ali";
            Age = 22;
            Dept = new Department();
        }

        public Employee(int _id,string _name,int _age,Department _dept)
        {
            Id = _id;
            Name = _name;
            Age = _age;
            Dept = _dept;
        }
        public Employee(Employee old)
        {
            Id=old.Id;
            Name = old.Name;
            Age = old.Age;
            Dept = old.Dept;
        }

        public override string ToString()
        {
            return $"{Id},{Name},{Age},{Dept?.ToString()}";
        }

        public int CompareTo(object? obj)
        {
            var right=obj as Employee;

            return this.Dept.CompareTo(right.Dept);
            //return this.Dept.DeptName.CompareTo(right.Dept.DeptName);
            //return this.Name.CompareTo(right.Name);
            //return this.Age.CompareTo(right.Age);
        }

        public object Clone()
        {
            return new Employee
            {
                Id = this.Id,
                Name= this.Name,
                Age = this.Age,
                Dept = this.Dept
            };

            return new Employee(this);
        }
    }
}
