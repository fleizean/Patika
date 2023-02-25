using System;

namespace drawtriangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Triangle Lenght: ");
            int len = Convert.ToInt32(Console.ReadLine());

            Triangle triangle = new Triangle(len);
            triangle.Draw();
        }
    }
    public class Triangle
    {
        private int _len;

        // cons
        public Triangle(int len)
        {
            if(len >= 1)
                this._len = len;
            else
                Console.WriteLine("Wrong Length!");
        }

        // get set
        public int Lenght {
            get { return _len; }
            set {
                    if(value < 1) 
                        Console.WriteLine("Wrong Length!");
                    else
                        _len = value; 
                }
        }

        public void Draw()
        {
            for (int i = 1; i <= Lenght; i++)
            {
                for (int j = 1; j <= Lenght - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
            Console.WriteLine();
            }
        }
    }
}
