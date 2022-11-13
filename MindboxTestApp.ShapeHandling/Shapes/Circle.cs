using MindboxTestApp.ShapeHandling.Interfaces;

namespace MindboxTestApp.ShapeHandling.Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            if(radius <= 0)
            {
                throw new ArgumentOutOfRangeException(null, "Radius must be a positive number");
            }

            Radius = radius;
        }
        public double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
