using MindboxTestApp.ShapeHandling.Interfaces;
using MindboxTestApp.ShapeHandling.Shapes;

namespace MindboxTestApp.ShapeHandling
{
    public class SquareCalculator
    {
        public static double CalculateSquare(IShape shape)
        {
            return shape.GetSquare();
        }        
    }
}