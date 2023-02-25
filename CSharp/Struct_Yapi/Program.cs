using System;

namespace struct_yapi
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle._longestSide = 4;
            rectangle._shortestSide = 3;
            Console.WriteLine("Class Area Result: {0}",rectangle.CalculateArea());

            Console.WriteLine("**************");
            
            Rectangle_Struct s_rectangle = new Rectangle_Struct(3, 4);
            Console.WriteLine("Struct Area Result: {0}",s_rectangle.CalculateArea());

        }
    }

    class Rectangle
    {
        public int _shortestSide;
        public int _longestSide;

        public Rectangle()
        {
            _shortestSide = 3;
            _longestSide = 4;
        }

        public long CalculateArea()
        {
            return (this._shortestSide * this._longestSide);
        }
    }

    struct Rectangle_Struct
    {
        public int shortestSide;
        public int longestSide;

        public Rectangle_Struct(int shortestside, int longestside)
        {

            shortestSide = shortestside;
            longestSide = longestside;
        }

        public long CalculateArea()
        {
            return (this.shortestSide * this.longestSide);
        }
    }
}