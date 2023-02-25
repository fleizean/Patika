using System;
using System.Collections;
using System.Collections.Generic;

namespace soru2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayList sumList = new ArrayList();
            ArrayList sumSmallests = new ArrayList();
            ArrayList sumBiggests = new ArrayList();
    
            int totalSmallest = 0;
            int totalBiggest = 0;
            for(int i = 0; i < 20; i++)
            {
                Console.Write("Enter {0}. sum: ", i + 1);
                int sum = Convert.ToInt32(Console.ReadLine());
                sumList.Add(sum);
            }
            sumList.Sort();
            for(int i = 0; i < 3; i++)
                sumSmallests.Add(sumList[i]);
            for(int i = 17; i < 20; i++)
                sumBiggests.Add(sumList[i]);
                
            foreach (var item in sumSmallests)
                totalSmallest += Convert.ToInt32(item);
            foreach (var item in sumBiggests)
                totalBiggest += Convert.ToInt32(item);
            Calculate(totalBiggest, totalSmallest);
        }
        static void Calculate(int totalBiggest, int totalSmallest)
        {
            Console.WriteLine("\n\n****** Calculater Step ******");
            Console.WriteLine("Total of biggest sum: {0}\nTotal of smallest sum: {1}\nAverage of biggest sum: {2}\nAverage of smallest num: {3}",totalBiggest, totalSmallest, (totalBiggest / 3), (totalSmallest / 3));
        }
    }
}