using System;

namespace drawcircle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle(radius);
            circle.Draw();
        }
    }
    public class Circle
    {
        private double _radius;
        public Circle(double radius)
        {
            if(radius >= 1)
                this._radius = radius;
            else
                Console.WriteLine("radius have to be positive number");
        }

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public void Draw()
        {
            double thickness = 0.4;
            Console.WriteLine("Circle Draw:");

            double rIn = Radius - thickness, rOut = Radius + thickness;
 
            for (double y = Radius; y >= -Radius; --y)
            {
                for (double x = -Radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}