using System;
using System.Collections.Generic;
namespace GradeBook
{
  
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Ole");
            book.AddGrade(89.1);
            book.AddGrade(9.1);
            book.AddGrade(86.1);
          
          var stats =  book.GetStats();

          Console.WriteLine("The statistics are {0},{1},{2}", stats.highGrade,stats.average,stats.lowGrade);

           
        }
    }
}
