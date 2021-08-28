using System;
using Xunit;


namespace GradeBook.Tests
{
    public class BookTests
    {
        public delegate string LogMessageDelegate(string logMessage);
        int count = 0;

        [Fact]
        public void LogMessageDelegateToMethod()
        {
            LogMessageDelegate log = ReturnMessage;
            log += ReturnMessage;
            log += MessageToLower;


            //initiliase log
            //log = new LogMessageDelegate (ReturnMessage);
            //log = ReturnMessage;

            var result = log("Hello");

            //Assert.Equal("Hello", result);
            Assert.Equal(3, count);

        }
            
        string MessageToLower(string returnMessage)
        {
            count++;
            return returnMessage.ToLower();
           
        }
        string ReturnMessage(string returnMessage)
        {
             count++;
            return returnMessage;
        }

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
            Assert.Equal('B', stats.Letter);

        }
        [Fact]
        public void TestGradeIsLessThanHundredAndIsPositive()
        {
            //arrange
            var book = new Book("");


            //act
            book.AddGrade(99.1);
            //book.AddGrade(590.1);
            //book.AddGrade(-78.1);
            book.AddGrade(0);
            book.AddGrade(100);

            //assert
            Assert.Equal(3, book.Grades.Count);
        }
    }
}
