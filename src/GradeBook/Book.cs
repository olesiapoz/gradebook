using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book( string name)
        {
            Grades = new List<double>();
            Name = name;

        }
        public void AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0 )
            {
            Grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Ivalid {nameof(grade)}");
            }
        }

        public Statistics GetStats()
        {
            var result = new Statistics();
            result.highGrade = double.MinValue;
            result.lowGrade = double.MaxValue;
            // foreach (double grade in Grades)
            // {
            //     result.highGrade = Math.Max(result.highGrade,grade);
            //     result.lowGrade = Math.Min(result.lowGrade,grade);
            //     result.average += grade;
            
            // }

            // ExecutionEngineException at least ones, before whilecondition is checked
            
            // if(Grades.Count>0)
            // {
            //     var i = 0;
            // do
            // {
            //     result.highGrade = Math.Max(result.highGrade,Grades[i]);
            //     result.lowGrade = Math.Min(result.lowGrade,Grades[i]);
            //     result.average += Grades[i]; 
            //     i++;
            // }
            // while (i<Grades.Count);
            // }

            // var i = 0;
            // while (i<Grades.Count)
            // {
            //     result.highGrade = Math.Max(result.highGrade,Grades[i]);
            //     result.lowGrade = Math.Min(result.lowGrade,Grades[i]);
            //     result.average += Grades[i]; 
            //     i++;
            // }

           
            for(int i=0; i<Grades.Count; i++)
            {
                result.highGrade = Math.Max(result.highGrade,Grades[i]);
                result.lowGrade = Math.Min(result.lowGrade,Grades[i]);
                result.average += Grades[i]; 
    
            }
           
         
            result.average /= Grades.Count;
            
            switch(result.average)
            {
                case var d when d >= 90:
                    result.Letter = 'A';
                    break;
                case var d when d >= 80:
                    result.Letter = 'B';
                    break;
                case var d when d >= 70:
                    result.Letter = 'C';
                    break;
                case var d when d >= 60:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'F';
                    break;
            }


            return result;
        }

        public List<double> Grades;
        public string Name;


    
    }
}