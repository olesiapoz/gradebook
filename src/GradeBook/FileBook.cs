using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace GradeBook
{
    public class FileBook: Book
    {
        public FileBook( string name):base(name)
        {
            Name = name;
            
        }
        public override void AddGrade(double grade)
        {
           // string currentDirName = Directory.GetCurrentDirectory();
            //var pathString = Path.Combine(currentDirName, $"{Name}.txt");
            if(grade <= 100 && grade >= 0 )
            {
               using(StreamWriter outputFile = File.AppendText($"{Name}.txt")){
                   
               if(GradeAdded != null)
            {
                GradeAdded(this, new EventArgs());
            }
             outputFile.WriteLine(grade.ToString());
            }
            }
            else
            {
                throw new ArgumentException($"Ivalid {nameof(grade)}");
            }
                   
            


        }

        public override Statistics GetStats()
        {
            string[] lines = File.ReadAllLines($"{Name}.txt");
            List<double> Grades  = new List<double>();
            foreach (string line in lines)
            {
                Grades.Add(Convert.ToDouble(line));
            }   
        
        var result = new Statistics();
        result.CalculateStatistics(Grades);
        return result;
            
        }
        public override event  GradeAddedDelegate  GradeAdded;

        

    }
}