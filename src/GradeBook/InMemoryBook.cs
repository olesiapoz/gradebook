using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class InMemoryBook : Book
    {
        public InMemoryBook( string name):base(name)
        {
            Grades = new List<double>();
            Name = name;

        }
        public override void AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0 )
            {
            Grades.Add(grade);
            //track grade is added event
            if(GradeAdded != null)
            {
                GradeAdded(this, new EventArgs());
            }
            }
            else
            {
                throw new ArgumentException($"Ivalid {nameof(grade)}");
            }
        }

        public override Statistics GetStats()
        {
        var result = new Statistics();
        result.CalculateStatistics(Grades);
        return result;
        }
        public override event  GradeAddedDelegate  GradeAdded;

        public List<double> Grades
        {
            get;
            set;
        }
    
    
    }
}