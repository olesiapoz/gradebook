using System;
using System.Collections.Generic;
namespace GradeBook
{
    public class Statistics
    {
        public Statistics() {
            highGrade = double.MinValue;
            lowGrade = double.MaxValue;
            average = 0.0;
    }

    public  void CalculateStatistics(List<double> Grades)
    {
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
                highGrade = Math.Max(highGrade,Grades[i]);
                lowGrade = Math.Min(lowGrade,Grades[i]);
                average += Grades[i]; 
    
            }
           
            average /= Grades.Count;
            
            switch(average)
            {
                case var d when d >= 90:
                    Letter = 'A';
                    break;
                case var d when d >= 80:
                    Letter = 'B';
                    break;
                case var d when d >= 70:
                    Letter = 'C';
                    break;
                case var d when d >= 60:
                    Letter = 'D';
                    break;
                default:
                    Letter = 'F';
                    break;
            }
        }
    
        public double average;
        public double lowGrade;
        public double highGrade;

        public char Letter;
    
    }

    
}