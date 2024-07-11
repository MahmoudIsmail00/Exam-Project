using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD10
{
    interface IEmployeeService
    {
        void Add(Employee employee);
        void Delete(Employee employee);
        Employee[] GetAll();
        Employee GetEmployee();
        void Update(Employee employee);
    }
    interface IDepartmentService
    {
        void Add(Department employee);
        void Delete(Department employee);
        Department[] GetAll();
        Department GetEmployee();
        void Update(Department employee);
    }

    //repository pattern
    interface ICompanyService<T>
    {
        void Add(T item);
        void Delete(T item);
        T[] GetAll();
        T GetOne();
        void Update(T item);
    }

    class Emp : ICompanyService<Employee>
    {
        public void Add(Employee item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Employee item)
        {
            throw new NotImplementedException();
        }

        public Employee[] GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetOne()
        {
            throw new NotImplementedException();
        }

        public void Update(Employee item)
        {
            throw new NotImplementedException();
        }
    }
    class Dept : ICompanyService<Department>
    {
        public void Add(Department item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Department item)
        {
            throw new NotImplementedException();
        }

        public Department[] GetAll()
        {
            throw new NotImplementedException();
        }

        public Department GetOne()
        {
            throw new NotImplementedException();
        }

        public void Update(Department item)
        {
            throw new NotImplementedException();
        }
    }


    //exclusive with generic [interface,delegate]  in,out

    interface IMath<in T, out U>
    {
        U Add(T left, T right);
    }
    class M : IMath<int, double>
    {
        public double Add(int left, int right)
        {
            throw new NotImplementedException();
        }
    }



    class Trial
    {
        public void Swap<T>(T x,T y)
        {
            T tmp = x;
            x=y; 
            y=tmp;
        }
    }

}
