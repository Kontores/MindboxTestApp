using MindboxTestApp.ShapeHandling;
using MindboxTestApp.ShapeHandling.Interfaces;
using MindboxTestApp.ShapeHandling.Shapes;
namespace MindboxTestApp.DesktopClient
{
    public class UIFacade
    {
        public IShape Shape { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
        public string SuccessMessage { get; set; } = string.Empty;

        public void CreateTriangle(string sideOneString, string sideTwoString, string sideThreeString)
        {
            ResetDefaults();

            double sideOne;
            double sideTwo;
            double sideThree;

            if (!double.TryParse(sideOneString, out sideOne))
            {
                ErrorMessage = GetParseErrorMessage(sideOneString);
                return;
            }

            if (!double.TryParse(sideTwoString, out sideTwo))
            {
                ErrorMessage = GetParseErrorMessage(sideTwoString);
                return;
            }

            if (!double.TryParse(sideThreeString, out sideThree))
            {
                ErrorMessage = GetParseErrorMessage(sideOneString);
                return;
            }

            try
            {
                Shape = new Triangle(sideOne, sideTwo, sideThree);
                SuccessMessage = $"Current Shape: Triangle, dimensions: {sideOne}, {sideTwo}, {sideThree}";
            }
            catch (ArgumentOutOfRangeException exception)
            {
                ErrorMessage = exception.Message;
            }
        }

        public void CreateCircle(string radiusString)
        {
            ResetDefaults();

            double radius;

            if (!double.TryParse(radiusString, out radius))
            {
                ErrorMessage = GetParseErrorMessage(radiusString);
                return;
            }
            try
            {
                Shape = new Circle(radius);
                SuccessMessage = $"Current Shape: Circle, radius: {radius}";
            }
            catch (ArgumentOutOfRangeException exception)
            {
                ErrorMessage = exception.Message;
            }
        }

        public double CalculateSquare(int precision = 2)
        {
            return Math.Round(SquareCalculator.CalculateSquare(Shape), precision);
        }

        public bool IsRightTriangle()
        {
            var triangle = Shape as Triangle;
            return triangle.IsRight;          
        }

        public List<ShapeListItem> GetShapeListItems()
        {
            return new List<ShapeListItem>()
            {
                new ShapeListItem(ShapeType.Circle, "Circle"),
                new ShapeListItem(ShapeType.Triangle, "Triangle")
            };
        }

        private void ResetDefaults()
        {
            ErrorMessage = string.Empty;
            SuccessMessage = string.Empty;
            Shape = null!;
        }

        private string GetParseErrorMessage(string incorrectValue) => 
            string.IsNullOrWhiteSpace(incorrectValue) ? "Value cannot be empty" : $"{incorrectValue} is not a correct value";
    }
}
