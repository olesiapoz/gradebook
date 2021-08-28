using System;
using System.Collections.Generic;
namespace GradeBook
{
  
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Ole");
            
    

        while(true)
        {
            Console.WriteLine($"Provide grade value for book {book.Name} or enter Q to quit");
            var input = Console.ReadLine();
            //if(String.Equals(input, "q", StringComparison.OrdinalIgnoreCase))
            if(input == "q")
            {
                break;
            };
            try
            {
            var grade = double.Parse(input);
            book.AddGrade(grade);
            Console.WriteLine("Grade {0} is added to Book {1}", grade, book.Name);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
             catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("**");
            }
            
        }
        
       
          
          var stats =  book.GetStats();

          Console.WriteLine("The statistics are {0},{1},{2},{3}", stats.highGrade,stats.average,stats.lowGrade, stats.Letter);

           
        }
    }
}
