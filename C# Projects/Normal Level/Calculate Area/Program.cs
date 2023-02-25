using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace calculatearea
{
    public enum ShapeLevel
    {
        Circle = 1,
        Triangle = 2,
        Square = 3,
        Rectangle = 4
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            CalculateArea carea = new CalculateArea();

            Console.WriteLine("******** Calculate Area ********");
            Console.WriteLine("1- Circle");
            Console.WriteLine("2- Triangle");
            Console.WriteLine("3- Square");
            Console.WriteLine("4- Rectangle");
            Console.WriteLine("5- Exit");
            Console.WriteLine("********************************");

            Console.Write("\nChoose your option: ");
            int chooseAction = Convert.ToInt32(Console.ReadLine());
            switch(chooseAction)
            {
                case 1:
                    carea.Circle();
                    carea.PrintResult();
                    break;
                case 2:
                    carea.Triangle();
                    carea.PrintResult();
                    break;
                case 3:
                    carea.Square();
                    carea.PrintResult();
                    break;
                case 4:
                    carea.Rectangle();
                    carea.PrintResult();
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Wrong Choose, exiting...");
                    break;
            }
        }
    }
    public class CalculateArea
    {
        private double _area;
        private int _WhichShape;
        public double Area{
            get { return _area; }
            set { _area = value; }
        }

        public int WhichShape{
            get { return _WhichShape; }
            set { _WhichShape = value; }
        }
        public void Circle()
        {
            double r;

            Console.Write("Enter the radius of the circle: ");
            r = Convert.ToDouble(Console.ReadLine());

            Area = Math.PI * r * r;
            WhichShape = 1;
        }
        public void Triangle()
        {
            double baseLength, height;
            Console.Write("Enter the base length of the triangle: ");
            baseLength = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height of the triangle: ");
            height = Convert.ToDouble(Console.ReadLine());

            Area = 0.5 * baseLength * height;
            WhichShape = 2;
        }
        public void Square()
        {
            double sideLength;

            Console.Write("Enter the side length of the square: ");
            sideLength = Convert.ToDouble(Console.ReadLine());

            Area = sideLength * sideLength;
            WhichShape = 3;
        }
        public void Rectangle()
        {
            double width, height;
            Console.Write("Enter the width of the rectangle: ");
            width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height of the rectangle: ");
            height = Convert.ToDouble(Console.ReadLine());

            Area = width * height;
            WhichShape = 4;
        }

        public void PrintResult()
        {
            string[] names = Enum.GetNames(typeof(ShapeLevel));
            foreach(int i in Enum.GetValues(typeof(ShapeLevel)))
            {
                if(i == WhichShape)
                    Console.WriteLine("Area of " + names[i] + ": " + Area);
            }
        }
    }
}