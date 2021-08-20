using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book( string name)
        {
            grades = new List<double>();
            this.name=name;

        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStats()
        {
            var result = new Statistics();
            result.highGrade = double.MinValue;
            result.lowGrade = double.MaxValue;
            foreach (double grade in grades)
            {
                result.highGrade = Math.Max(result.highGrade,grade);
                result.lowGrade = Math.Min(result.lowGrade,grade);
                result.average += grade;
            
            }
            result.average /= grades.Count;

            return result;
        }

        List<double> grades;
        string name;


    
    }
}