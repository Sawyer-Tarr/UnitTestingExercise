using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(1, 2, 3, 6)]
        [InlineData(42, 28, 59, 129)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator challenger = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            var actual = challenger.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]//Add test data <-------
        [InlineData(2, 1, 1)]//Add test data <-------
        [InlineData(56, 24, 32)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator challenger = new Calculator();

            //Act
            var actual = challenger.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 5, 20)]//Add test data <-------
        [InlineData(2, 8, 16)]//Add test data <-------
        [InlineData(28, 34, 952)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator challenger = new Calculator();


            //Act
            var actual = challenger.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 2)]//Add test data <-------
        [InlineData(100, 20, 5)]//Add test data <-------
        [InlineData(8, 2, 4)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator challenger = new Calculator();
            //Act
            var actual = challenger.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
