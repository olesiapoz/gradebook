using System;
using Xunit;


namespace GradeBook.Tests
{
    public class TypeTests
    {
      [Fact] 
       public void IntPassedByRef()
        {
            //arrange
            var x = GetInt();
            SetIntByRef(ref x);
            //act
            

            //assert
            Assert.Equal(42, x);
            
        }
       [Fact] 
       public void IntPassedByValue()
        {
            //arrange
            var x = GetInt();
            SetInt(x);
            //act
            

            //assert
            Assert.Equal(3, x);
            
        }
        [Fact]
        public void PassedByRef()
        {
            //arrange
            var book1 = GetBook("Book 1");
            GetBookSetRefName( ref book1,"New Name");
            //act
            

            //assert
            Assert.Equal( "New Name", book1.Name);
            
        }
        [Fact]
        public void PassedByValue()
        {
            //arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(book1,"New Name");
            //act
            

            //assert
            Assert.Equal( "Book 1", book1.Name);
            
        }
        [Fact]
        public void CanSetNameOfObjectbyReference()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;
            SetBookName(book1,"New Name");
            //act
            

            //assert
            Assert.Equal( "New Name", book2.Name);
            
        }
        [Fact]
        public void GetBookReturnsDifferentMethods()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            //act
            

            //assert
            Assert.Equal( "Book 1", book1.Name);
            Assert.Equal( "Book 2", book2.Name);
            Assert.NotSame(book1,book2);
            Assert.False(Object.ReferenceEquals(book1, book2));
        }

        [Fact]
        public void TwoVariablesReferenceSameObject()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;

            //act
            

            //assert
            Assert.Equal( book1.Name, book2.Name);
            Assert.Same(book1,book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }


        Book GetBook(string name)
        {
            return new Book(name);
        } 

        void SetBookName(Book book, string name)
        {
            book.Name = name;
        }
        void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }
        void GetBookSetRefName(ref Book book, string name)
        {
            book = new Book(name);
        }

        int GetInt()
        {
            return 3;
        }
        void SetInt(int x)
        {
            x=42;
        }

         void SetIntByRef(ref int x)
        {
            x=42;
        }
        
    }
}
