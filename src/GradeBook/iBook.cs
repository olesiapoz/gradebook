namespace GradeBook
{
    public  interface IBook
    {
      string Name{get;}
       Statistics GetStats(); 
       void AddGrade(double grade);
       event GradeAddedDelegate  GradeAdded;
    }
}