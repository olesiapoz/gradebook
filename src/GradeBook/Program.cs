using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
        

            double result=0;
            List<double> grades = new List<double>() {1,2,3,4};

            foreach (double number in grades)
            {
                result += number;
            
            }
            
            Console.WriteLine(result/grades.Count);

            if(args.Length>0)
            {
            Console.WriteLine("Hello {0}",args);
        
            }
            else
            {
            Console.WriteLine("Hello");

            }
        }
    }
}
