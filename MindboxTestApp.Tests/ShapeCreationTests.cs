using Xunit;
using MindboxTestApp.ShapeHandling;
using MindboxTestApp.ShapeHandling.Shapes;

namespace MindboxTestApp.Tests
{
    public class ShapeCreationTests
    {
        [Fact]
        public void TriangleCreationTest()
        {
            // Arrange
            Triangle triangle = null;
            string exceptionMessage = String.Empty;
            triangle = new Triangle(10, 9, 8);
            // Act
            try 
            {
                triangle = new Triangle(10, 20, 12);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                exceptionMessage = exception.Message;
            }

            //Assert
            Assert.NotNull(triangle);
            Assert.Equal(10, triangle.SideOne);
            Assert.True(String.IsNullOrWhiteSpace(exceptionMessage));

        }

        [Fact]
        public void TriangleNonPositiveSideErrorTest()
        {
            // Arrange
            Triangle triangle = null;
            string exceptionMessage = String.Empty;

            // Act
            try
            {
                triangle = new Triangle(0, 20, 12);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                exceptionMessage = exception.Message;
            }

            //Assert
            Assert.Null(triangle);
            Assert.Equal("Each side length must be a positive number", exceptionMessage);

        }

        [Fact]
        public void TriangleBigSideErrorTest()
        {
            // Arrange
            Triangle? triangle = null;
            string exceptionMessage = String.Empty;

            // Act
            try
            {
                triangle = new Triangle(100, 20, 12);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                exceptionMessage = exception.Message;
            }

            //Assert
            Assert.Null(triangle);
            Assert.Equal("Each side must be less than sum of the two other sides", exceptionMessage);

        }

        [Fact]

        public void CircleCreationTest()
        {
            // Arrange
            Circle circle = null;
            string exceptionMessage = String.Empty;

            // Act
            try
            {
                circle = new Circle(10);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                exceptionMessage = exception.Message;
            }

            //Assert
            Assert.NotNull(circle);
            Assert.Equal(10, circle.Radius);
            Assert.True(String.IsNullOrWhiteSpace(exceptionMessage));
        }

        [Fact]
        public void CircleNonPositiveErrorTest()
        {
            // Arrange
            Circle circle = null;
            string exceptionMessage = String.Empty;

            // Act
            try
            {
                circle = new Circle(-5);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                exceptionMessage = exception.Message;
            }

            //Assert
            Assert.Null(circle);
            Assert.Equal("Radius must be a positive number", exceptionMessage);
        }
    }
}