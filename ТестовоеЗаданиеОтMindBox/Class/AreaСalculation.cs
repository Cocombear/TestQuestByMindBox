namespace ТестовоеЗаданиеОтMindBox.Class
{
    public static class AreaСalculation
    {
        public static double CalculatingAreaOfCircle(double radiusCircle) 
        { 
            return radiusCircle * radiusCircle * Math.PI; 
        }
        public static double CalculatingAreaOfSquare(double sideSquare) 
        {
            return sideSquare * sideSquare;
        }
        public static double CalculatingAreaOfTriangle(double firstSideTriangle, double secondSideTriangle, double thirdSideTriangle)
        {
            double semiPerimeter = (firstSideTriangle + secondSideTriangle + thirdSideTriangle) / 2;
            return Math.Sqrt((semiPerimeter * (semiPerimeter - firstSideTriangle) * (semiPerimeter - secondSideTriangle) * (semiPerimeter - thirdSideTriangle)));
        }
        public static double CalculatingAreaOfTrapeze(double firstTrapezBaseLength, double secondTrapezBaseLength, double trapezHeight)
        { 
            return (firstTrapezBaseLength + secondTrapezBaseLength) / 2 * trapezHeight; 
        }
        public static double CalculatingAreaOfCylinder(double cylinderHeight, double radiusCylinder)
        { 
            return 2 * Math.PI * radiusCylinder * (cylinderHeight + radiusCylinder); 
        }
    }
}
