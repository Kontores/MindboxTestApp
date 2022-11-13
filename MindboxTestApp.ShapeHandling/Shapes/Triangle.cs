using MindboxTestApp.ShapeHandling.Interfaces;

namespace MindboxTestApp.ShapeHandling.Shapes
{
    public class Triangle : IShape
    {
        public double SideOne { get; }
        public double SideTwo { get; }
        public double SideThree { get; }
        public bool IsRight { get => IsRightTriangle(); }
        public Triangle(double sideOne, double sideTwo, double sideThree)
        {
            if(sideOne <= 0 || sideTwo <= 0 || sideThree <= 0)
            {
                throw new ArgumentOutOfRangeException(null, "Each side length must be a positive number");
            }
            
            if(!AreSidesCorrect(sideOne, sideTwo, sideThree))
            {
                throw new ArgumentOutOfRangeException(null, "Each side must be less than sum of the two other sides");
            }

            SideOne = sideOne;
            SideTwo = sideTwo;
            SideThree = sideThree;
        }
        public double GetSquare()
        {
            var halfPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideOne) * (halfPerimeter - SideTwo) * (halfPerimeter - SideThree));
        }

        public double GetPerimeter()
        {
            return SideOne + SideTwo + SideThree;
        }

        /// <summary>
        /// Checks if square of one side is equal to sum of other sides squares
        /// Possible to follow the DRY principle using linq expression (declare list then use Any with index of), 
        /// but looks not the best way in this case as is much less readable
        /// </summary>
        /// <returns>is triangle right or not boolean value</returns>
        private bool IsRightTriangle()
        {
            if (Math.Pow(SideOne, 2) == (Math.Pow(SideTwo, 2) + Math.Pow(SideThree, 2)))
                return true;
            if (Math.Pow(SideTwo, 2) == (Math.Pow(SideOne, 2) + Math.Pow(SideThree, 2)))
                return true;
            if (Math.Pow(SideThree, 2) == (Math.Pow(SideTwo, 2) + Math.Pow(SideOne, 2)))
                return true;

            return false;
        }

        /// <summary>
        /// Checks the triangle rule - one side should be shorter than the sum of the other two sides
        /// </summary>
        /// <returns>boolean for the triangle sides rule</returns>
        private bool AreSidesCorrect(double sideOne, double sideTwo, double sideThree)
        {
            return (sideOne < sideTwo + sideThree)
                && (sideTwo < sideOne + sideThree) && (sideThree < sideOne + sideTwo);
        }
    }
}
