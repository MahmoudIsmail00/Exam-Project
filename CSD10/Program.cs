using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSD10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Interface
            ////classA 
            ////classB
            ////classC :classA,classB   ???  NOOOOOO

            ////interface: protocol bet. classes
            /////interface is reference type
            /////interface is like abstract class
            /////interface in one of data type that is written inside namespace
            /////we can write methods and property inside interface
            /////methods inside interface MUST be abstract method  //untilc#9
            /////properties inside interface MUST be auto property //untilc#9
            /////properties&methods inside inteface dont use access modifier;
            ///as it is implemented ALWAYS public //untilc#9
            /////you can inherit/implement Multiple Interfaces

            /////
            ///interface IInterface
            ///{
            //////method headers only
            //////auto property only
            ///}

            //HrSystem o1=new HrSystem();
            //IMyInterface o2;
            //o2=new HrSystem();


            //MathService mservice = new MathService();
            //Console.WriteLine(((IMathService)mservice).Add(11,22));
            //Console.WriteLine((mservice as IAlgorithmService).Add(22,33));

            //IMathService i1 = new MathService();
            //i1.Add(22, 33);
            //IAlgorithmService i2 = mservice;//new MathService();
            //i2.Add(22, 33);

            #endregion

            #region Sort Arrays of built-in DT
            //int[] numbers = { 6, 5, 4, 3, 2, 3, 5, 67, 7, -77, 666 };
            //string[] names = { "Ziad", "Osama", "Nada", "Alaa", "Aalaa" };

            //Array.Sort(names);  //clr call CompareTo inside IComparable 

            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}

            ////Employee e1 = new Employee { Id = 1, Name = "Amr", Age = 22 };
            ////Console.WriteLine(e1);
            #endregion

            #region Sort Arrays of user-defined DT
            //Employee[] employees = 
            //{
            //    new Employee{Id=1, Name="Ziad",Age=22,Dept=new Department{ DeptId=20, DeptName="OS"} },
            //    new Employee{Id=2, Name="Sara",Age=23,Dept=new Department() },
            //    new Employee{Id=3, Name="Ali",Age=26,Dept=new Department() },
            //    new Employee{Id=4, Name="Aya",Age=24,Dept=new Department{ DeptId=20, DeptName="OS"} },
            //    new Employee{Id=5, Name="Aalaa",Age=25,Dept=new Department{ DeptId=30, DeptName="UI"} },
            //};

            //Array.Sort(employees);

            //foreach (Employee employee in employees) 
            //{
            //    Console.WriteLine(employee);
            //}
            #endregion

            #region Clone
            ////int[] arr = { 1, 2, 3, 4, 5 };
            ////int[] arr2 = arr.Clone() as int[];
            ////Console.WriteLine(arr.GetHashCode());
            ////Console.WriteLine(arr2.GetHashCode());

            //Employee e1 = new Employee { Id = 1, Name = "Amr", Age = 22 };
            //Employee e2 = e1.Clone() as Employee;
            //Console.WriteLine(e1.GetHashCode());
            //Console.WriteLine(e2.GetHashCode());
            #endregion

            #region Mutable,Immutable
            ///////Mutable object:
            /////////Object we can change its [*state*] anytime 
            ///////Immutable object:
            /////////object when created ,
            /////////you cannot change its state EVER

            //Employee e1= new Employee();
            //e1.Id = 222;
            //Console.WriteLine(e1.GetHashCode());

            //Point p1 = new Point(3, 4);
            //p1 = new Point(33, 44);

            //Point p2 = new Point { X = 2, Y = 3 };
            ////p2.X = 222;
            //Console.WriteLine(p1.GetHashCode());

            #endregion

            #region String Dt is Immutable Object  intern pool [table]
            //string str = "My";
            //str += " name";
            //str += " is";
            ////Console.WriteLine("my name is"+ varia +"and age ="+ var);

            //var fname = "mohamed Ali";
            //var lname = "mohamed";
            //lname += " Ali";
            //Console.WriteLine(fname.GetHashCode());
            //Console.WriteLine(lname.GetHashCode());


            #endregion

            #region stringBuilder
            //StringBuilder sb=new StringBuilder();
            //sb.Append("Hello");
            //sb.Append("Dear");
            //Console.WriteLine(sb.GetHashCode());
            #endregion

            #region Template -> Generics V01
            ///generic + container DT
            ///generic make write code once
            ///and can be cantainer for any DT
            ///
            ///mystack s1=new mystack();
            //MyStack s1 = new MyStack();


            //MyStack<int> s1=new MyStack<int>();
            //MyStack<Employee> s2=new MyStack<Employee>();
            //s2.Push()
            #endregion

            #region Generics constraints V02
            //MyStack<int> s1 = new MyStack<int>();
            //MyStack<string> s2= new MyStack<string>();
            //MyStack<Employee> s3=new MyStack<Employee>();
            #endregion

            #region Array Big Issue
            //FIXED SIZE
            #endregion

            #region ArrayList    ///NON Generic Collection   System.Collections
            //ArrayList a=new ArrayList(4);
            //a.Add(1);
            //a.Add("Sara");
            //a.Add(new Employee());

            #endregion

            #region Generic Collection => List<T>
            //List<int> nums= new List<int>(5);
            //nums.Add(1);
            //nums.Add(2);
            //nums.Add(3);
            //nums.Add(4);
            //nums.Add(5);
            //Console.WriteLine(nums.Capacity); //5
            //nums.Add(6);
            //Console.WriteLine(nums.Capacity); //10
            //nums.Add(7);
            //nums.Add(8);
            //nums.Add(9);
            //nums.Add(10);
            //Console.WriteLine(nums.Capacity); //10
            //nums.Add(11);
            //Console.WriteLine(nums.Capacity); //20

            ////nums.Remove(2);

            //nums[0] = 1000; //update
            ////nums[11] = 1234; //insert XXXXXX
            //Console.WriteLine(nums[10]);
            //Console.WriteLine("===================");
            //foreach (int i in nums) 
            //{
            //    Console.WriteLine(i);
            //}

            //List<Employee> employees = new List<Employee>() 
            //{
            //    new Employee{Id=1, Name="Ziad",Age=22,Dept=new Department{ DeptId=20, DeptName="OS"} },
            //    new Employee{Id=2, Name="Sara",Age=23,Dept=new Department() },
            //    new Employee{Id=3, Name="Ali",Age=26,Dept=new Department() },
            //    new Employee{Id=4, Name="Aya",Age=24,Dept=new Department{ DeptId=20, DeptName="OS"} },
            //    new Employee{Id=5, Name="Aalaa",Age=25,Dept=new Department{ DeptId=30, DeptName="UI"} },

            //};

            //List<int> arr = new(){1,2,3,4,5,6 };
            //nums.AddRange(arr);
            //nums.AddRange(new int[] { 22,33,44,55});
            //Console.WriteLine(nums.Count);

            ///////1,2,3,55,66,77
            ///////
            ////List<int> tmpNums = new List<int>(100);
            ////tmpNums.Add(1);
            ////tmpNums.Add(2);
            ////tmpNums.Add(3);

            ////Console.WriteLine(tmpNums.Count);
            ////tmpNums.TrimExcess();
            ////Console.WriteLine(tmpNums.Capacity);
            ////Console.WriteLine("-------");
            ////tmpNums.Remove(1);
            ////Console.WriteLine($"===>{tmpNums[0]}");
            ////Console.WriteLine(tmpNums.Count);
            ////tmpNums.TrimExcess();
            ////Console.WriteLine(tmpNums.Capacity);
            #endregion

            #region Dictionary<Key,Value> Generic collections
            //Dictionary<int,string> map= new Dictionary<int,string>();
            //map.Add(1, "Ali");
            //map.Add(2, "Sara");
            //map.Add(3, "Omar");
            //map.Add(4, "Aya");
            ////map.Add(4, "Waleed");
            ////keyvaluepair

            //map[4] = "Eman"; //update
            //map[10] = "Osama"; //insert

            ////map.Add(4, "Waleed");
            //if( map.TryAdd(4, "Waleed")) 
            //{
            //    ///
            //}
            //else
            //{
            //    map[4] = "Waleed";
            //}

            //foreach (var item in map)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}


            ///key + gethashcode

            #endregion

            #region Additional data with Add  [List]
            //List<int> nums = new List<int>();
            //nums.Add(1);  //Add functionality to add in file

            //Console.WriteLine("=================");
            //Kamal o1 = new Kamal();
            //o1.Add(1);
            //o1.Add(2);
            //o1.Add(3);
            //Console.WriteLine("i'm print data inside list");
            //foreach (int i in o1) 
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("done printing");
            //Console.WriteLine("=================");





            //nums.Add(1);
            //MyList<int> l1 = new MyList<int>(); 
            #endregion

            #region REMEMBER [LINQ]
            /////ALL COLLECTIONS : IEnumerable
            /////
            //IEnumerable<int> xarr=new List<int>();
            //IEnumerable arr = new int[] { 1, 2, 3, 4 };
            #endregion

            #region Lab Assignment
            ///Examination System
            ///practice exam
            ///final exam
            #endregion

            MyDelegate<int,string > del1 = x => x.ToString();

            Console.WriteLine(del1.Invoke(5));
        }
        public delegate U MyDelegate<T, U>(T item);

    }
}
