using System;
using System.Collections.Generic;
namespace GradeBook
{
  
    class Program
    {
        static void Main(string[] args)
        //static methods can reach only static members of its class
        {
            IBook book = new FileBook("Ole");
            book.GradeAdded += GradeIsAdded;

            EnterGrade(book);

            var stats = book.GetStats();

            Console.WriteLine("The statistics are {0},{1},{2},{3}", stats.highGrade, stats.average, stats.lowGrade, stats.Letter);

        }

        private static void EnterGrade(IBook book)
        {
            while (true)
            {
                Console.WriteLine($"Provide grade value for book {book.Name} or enter Q to quit");
                var input = Console.ReadLine();
                //if(String.Equals(input, "q", StringComparison.OrdinalIgnoreCase))
                if (input == "q")
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
        }

        //subscribe to GradeAdded event
        static void GradeIsAdded(object sender, EventArgs e)
    {
    Console.WriteLine($"Grade is added to the book {sender}");
    }
    }
}
