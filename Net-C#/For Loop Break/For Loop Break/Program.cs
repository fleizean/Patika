using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        // Ekrandan girilen sayiya kadar olan tek say1larin1 ekrana ya7di r,
        Console.Write("Lütfen bir saya giriniz: ");
        int sayac = int.Parse(Console.ReadLine());
        for (int i = 1; 1 <= sayac; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
        }
        int oddResult = 0;
        int evenResult = 0;
        for (int i = 1; i <= 1000; i++)
        {
            if (i % 2 == 1)
                oddResult += i;
            else
                evenResult += i;
        }
        Console.WriteLine("Odd Result : ", oddResult);
        Console.WriteLine("Even Result : ", evenResult);

        for (int i = 0; i < 10; i++)
        {
            if (i == 4)
                break;
            Console.WriteLine(i);
        }
    }
}