using System;

namespace sumofintegerpairs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.Write("How many pairs will you enter: ");
            int n = Convert.ToInt32(Console.ReadLine());
            SumOfIntegerPair sip = new SumOfIntegerPair(n);
            for(int i = 1; i <= n; i++)
            {
                Console.Write("{0}. enter pair (x): ", i);
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("{0}. enter pair (y): ", i);
                int y = Convert.ToInt32(Console.ReadLine());
                sip.Num1 = x;
                sip.Num2 = y;
                sip.Calculate();
            }
            sip.Result();
        }
    }
    public class SumOfIntegerPair
    {
        static int i = 0;
        static int[] arr;
        private int _sum;
        private int _num1;
        private int _num2;
        public int Sum{
            get { return _sum; }
            set { _sum = value; }
        }

        public int Num1{
            get { return _num1; }
            set { _num1 = value; }
        }

        public int Num2{
            get { return _num2; }
            set { _num2 = value; }
        }
        public SumOfIntegerPair(int n)
        {
            arr = new int[n]; // dizi boyutu belirleniyor
        }
        public void Calculate()
        {
            if(Num1 == Num2)
                Sum = (Num1 + Num2) * (Num1 + Num2);
            else
                Sum = Num1 + Num2;
            arr[i] = Sum;
            i += 1;
            Sum = 0;
        }
        public void Result()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if(i != arr.Length - 1)
                    Console.Write(" ");
            }
        }
    }
}