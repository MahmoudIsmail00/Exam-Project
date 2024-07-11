using System.Collections.Generic;

namespace Lab
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string _type="";
            do
            {
                Console.WriteLine("Please choose Practise or Final");
                _type = Console.ReadLine().ToLower();

            } while (_type != "practise" && _type != "final");


            if(_type == "practise")
            {
                Exam exam = new PractiseExam(10);
                exam.ShowExam();
            }
            else if (_type == "final")
            {
                Exam exam = new FinalExam(10);
                exam.ShowExam();
            }
            else
            {
                Console.WriteLine("wrong answer");
            }

        }
    }
}
