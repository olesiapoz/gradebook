namespace GradeBook
{
    public abstract class Book:NamedObject, IBook
    {
        public Book( string name):base(name)
        {
        }
        public abstract void AddGrade(double grade);

        public abstract Statistics GetStats();

        public abstract event GradeAddedDelegate GradeAdded;
    }
}