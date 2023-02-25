using System;

namespace averagecalculation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Fibonacci Lenght: ");
            int len = Convert.ToInt32(Console.ReadLine());

            Calculate calc = new Calculate();
            int[] fibSerie = calc.Fibonacci(len);
            Console.WriteLine("\nAverage Result: " + calc.CalculateAverage(fibSerie, len));
        }
    }

    public class Calculate
    {
        public int[] Fibonacci(int len)
        {
            int[] fibSeries = new int[len];

            if(len < 1)
            {
                Console.WriteLine("Wrong Lenght!");
                return(fibSeries);
            }
            for (int i = 0; i < len; i++)
            {
                if(i == 0 || i == 1)
                    fibSeries[i] = i;
                else
                    fibSeries[i] = fibSeries[i - 1] + fibSeries[i - 2];
            }
            return fibSeries;
        }

        public double CalculateAverage(int[] arr, int len)
        {
            double sum = 0;

            Console.Write("Your Fibonacci Serie: ");
            foreach(int num in arr)
                Console.Write(num + " ");
            for (int i = 0; i < len; i++)
                sum += arr[i];
            return sum / arr.Length;
        }
    }
}