using System;
using Xunit;
using GradeBook;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void TestStatistics()
        {
            //arange
            var book = new Book("");
            book.AddGrade(99.1);
            book.AddGrade(90.1);
            book.AddGrade(76.1);

            //act
            var stats =  book.GetStats();

            //assert
            Asse
;
        }
    }
}
