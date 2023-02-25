    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    namespace soru1
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                int sum = 0;
                ArrayList sumArray = new ArrayList();
                ArrayList primeArray = new ArrayList();
                ArrayList nonPrimeArray = new ArrayList();

                int primeTotal = 0;
                int primeAverage = 0;
                int nonPrimeTotal = 0;
                int nonPrimeAverage = 0;
                for(int i = 0; i < 20; i++)
                {
                    try
                    {
                        Console.Write("Enter {0}. sum: ", i + 1);
                        sum = Convert.ToInt32(Console.ReadLine());
                        if(sum < 0)
                            Console.WriteLine("Please, enter positive sum");
                        else
                            sumArray.Add(sum);
                    }
                    catch
                    {
                        Console.WriteLine("Incorrect data type!");
                    }
                }

                foreach(var item in sumArray)
                {
                    if(isPrime(item) == true)
                    {
                        primeArray.Add(item);
                        primeTotal += Convert.ToInt32(item);
                    }
                    else
                    {
                        nonPrimeArray.Add(item);
                        nonPrimeTotal += Convert.ToInt32(item);
                    }
                }
                primeAverage = primeTotal / primeArray.Count;
                nonPrimeAverage = nonPrimeTotal / nonPrimeArray.Count;

                primeArray.Sort();
                primeArray.Reverse();
                nonPrimeArray.Sort();
                nonPrimeArray.Reverse();

                Console.WriteLine("******** Prime Array ********");
                foreach(var item in primeArray)
                    Console.Write(item + " ");
                Console.WriteLine("\nPrime array count: {0}\nPrime array average: {1}",primeArray.Count, primeAverage);
                Console.WriteLine("\n\n******** Non-Prime Array ********");
                foreach(var item in nonPrimeArray)
                    Console.Write(item + " ");
                Console.WriteLine("\nNon-Prime array count: {0}\nNon-Prime array average: {1}",nonPrimeArray.Count, nonPrimeAverage);
            }
            static bool isPrime(int number)
            {
               if (number <= 0) return false;
               for (int i = 2; i <= number/2; i++)
                   if (number % i == 0)
                       return false;
                return true;
            }
        }
    }