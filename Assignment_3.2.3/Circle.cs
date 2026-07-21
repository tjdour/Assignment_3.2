

namespace Assignment_3._2._3
{
    public class Circle
    {
        public double Radius { get; set; }

        public double Area
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }

        public Circle(double radius)
        { 
            Radius = radius;
        }

        public static double operator +(Circle c1, Circle c2)
        { 
            return c1.Area + c2.Area;
        }

        public static double operator -(Circle c1, Circle c2)
        {
            return c1.Area - c2.Area;
        }
        
        
    }
}
