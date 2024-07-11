using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD10
{
    ///I
    public interface IMyInterface
    {
        //methods header and auto properties
        void Hello();
        void MyName(string name);
        int Id { set; get; }
        string Name { set; get; }
    }
    public interface IMyInterface2
    {
        void SignIn();
        void SignOut();
    }
    class Parent { }
    class HrSystem : Parent,IMyInterface, IMyInterface2
    {
        public int Id
        {
            get
           ;

            set
           ;
        }

        public string Name
        {
            get
            ;
            set
            ;
        }

        public void Hello()
        {
            Console.WriteLine("Hello .net");
        }

        public void MyName(string name)
        {
            Console.WriteLine($"name={name}");
        }

        public void SignIn()
        {
            throw new NotImplementedException();
        }

        public void SignOut()
        {
            throw new NotImplementedException();
        }
    }

    interface IMathService
    {
        double Add(double x, double y);
        double Sub(double x,double y);
        double Mul(double x,double y);

    }
    interface IAlgorithmService
    {
        double Add(double x,double y);
        double Fraction(double x);
    }

    class MathService : IMathService, IAlgorithmService
    {
        ///if both interface have same business code
        //public double Add(double x, double y)
        //{
        //    throw new NotImplementedException();
        //}

        //if two functions have different implementation
        //you must implement functions explicitly
        //function must be private
        //function is written with interface name as fully name qualified
        double IMathService.Add(double x, double y)
        {
            return 1;
        }

        double IAlgorithmService.Add(double x, double y)
        {
            return 1;
        }


        public double Fraction(double x)
        {
            throw new NotImplementedException();
        }

        public double Mul(double x, double y)
        {
            throw new NotImplementedException();
        }

        public double Sub(double x, double y)
        {
            throw new NotImplementedException();
        }
    }

}
