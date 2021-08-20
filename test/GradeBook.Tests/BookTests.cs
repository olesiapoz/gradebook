using System;
using Xunit;


namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void TestStatistics()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(99.1);
            book.AddGrade(90.1);
            book.AddGrade(78.1);

            //act
            var stats =  book.GetStats();

            //assert
            Assert.Equal(89.1, stats.average,1);
            Assert.Equal(99.1, stats.highGrade,1);
            Assert.Equal(78.1, stats.lowGrade,1);
;
        }
    }
}
