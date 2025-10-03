
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(10, 0, 1.8, 11.8)]
        [InlineData(2, -12, 6, -4)]
        [InlineData(-4, 26, 20, 42)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Arrange
            // create a Calculator object
            var calculator = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calculator.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(210, 2, 208)]//Add test data <-------
        [InlineData(30, 27, 3)]
        [InlineData(50, -2, 52)]
        [InlineData(10, -5, 15)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var testSub = new Calculator();

            //Act
            var actual = testSub.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 50)]//Add test data <-------
        [InlineData(20, 10, 200)]
        [InlineData(30, 10, 300)]
        [InlineData(50, 10, 500)]
        [InlineData(10, 10, 100)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:
        
            //Arrange
            var multiTest = new Calculator();
        
            //Act
            var actual = multiTest.Multiply(num1, num2);
        
            //Assert
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(100, 2, 50)]//Add test data <-------
        [InlineData(100, 10, 10)]
        [InlineData(20, 10, 2)]
        [InlineData(50, 5, 10)]
        [InlineData(40, 10, 4)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var divider = new Calculator();

            //Act
            var actual = divider.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
