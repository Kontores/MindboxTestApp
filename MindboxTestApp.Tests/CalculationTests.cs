using Xunit;
using MindboxTestApp.ShapeHandling;
using MindboxTestApp.ShapeHandling.Shapes;
using MindboxTestApp.ShapeHandling.Interfaces;

namespace MindboxTestApp.Tests
{
    public class CalculationTests
    {
        [Fact]
        public void TriangleSquareCalculationTest()
        {
            // Arrange

            var triangleOne = new Triangle(10, 15, 23);
            var triangleTwo = new Triangle(5.5, 12.3, 8.6);
            var triangleThree = new Triangle(9, 4.5, 7);

            // Act

            var squareOne = Math.Round(SquareCalculator.CalculateSquare(triangleOne), 2);
            var squareTwo = Math.Round(SquareCalculator.CalculateSquare(triangleTwo), 2);
            var squareThree = Math.Round(SquareCalculator.CalculateSquare(triangleThree), 2);

            // Assert

            Assert.Equal(54.99, squareOne);
            Assert.Equal(20.51, squareTwo);
            Assert.Equal(15.47, squareThree);
        }

        [Fact]
        public void RightTriangleTest()
        {
            // Arrange

            var rightTriangleOne = new Triangle(4, 3, 5);
            var rightTriangleTwo = new Triangle(5, 12, 13);
            var regularTriangleOne = new Triangle(6, 7, 7);
            var regularTriangleTwo = new Triangle(9, 8, 4);

            // Act - can be removed here, but left in order to keep the tests structure unified

            var isTriangleOneRight = rightTriangleOne.IsRight;
            var isTriangleTwoRight = rightTriangleTwo.IsRight;
            var isTriangleThreeRight = regularTriangleOne.IsRight;
            var isTriangleFourRight = regularTriangleTwo.IsRight;

            // Assert

            Assert.True(isTriangleOneRight);
            Assert.True(isTriangleTwoRight);
            Assert.False(isTriangleThreeRight);
            Assert.False(isTriangleFourRight);
        }

        [Fact]
        public void CircleSquareTest()
        {
            // Arrange

            var circleOne = new Circle(5);
            var circleTwo = new Circle(7.5);
            var circleThree = new Circle(15);

            // Act

            var squareOne = Math.Round(SquareCalculator.CalculateSquare(circleOne), 1);
            var squareTwo = Math.Round(SquareCalculator.CalculateSquare(circleTwo), 1);
            var squareThree = Math.Round(SquareCalculator.CalculateSquare(circleThree), 1);

            // Assert

            Assert.Equal(78.5, squareOne);
            Assert.Equal(176.7, squareTwo);
            Assert.Equal(706.9, squareThree);
        }

        [Fact]
        public void RuntimeDifferentShapesCalculationTest()
        {
            // Arrange

            IShape shape = new Triangle(4, 3, 5);

            // Act
            
            var triangleSquare = SquareCalculator.CalculateSquare(shape);
            shape = new Circle(10);
            var circleSquare = Math.Round(SquareCalculator.CalculateSquare(shape));

            // Assert

            Assert.Equal(6, triangleSquare);
            Assert.Equal(314, circleSquare);

        }
    }
}