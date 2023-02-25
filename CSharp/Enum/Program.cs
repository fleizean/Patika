using System;

namespace struct_yapi
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = 20; // default value
            Console.WriteLine(Days.Sunday);
            Console.WriteLine((int)Days.Saturday);

            Console.Write("Enter a Temperature: ");
            temperature = Convert.ToInt32(Console.ReadLine());
            
            if(temperature <= (int)WeatherForecast.Clear)
                Console.WriteLine("Wait for the weather to warm up to go outside.");
            else if(temperature >= (int)WeatherForecast.Hot)
                Console.WriteLine("Wait for the weather to cool before going outside.");
            else if(temperature >= (int)WeatherForecast.Clear && temperature < (int)WeatherForecast.VeryHot)    
                Console.WriteLine("Let's go outside.");
        }
    }

    enum Days
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday = 23,
        Saturday,
        Sunday
    }

    enum WeatherForecast
    {
        Chilly = 20,
        Clear = 15,
        Cold = 1,
        Foggy = 8,
        Hot = 25,
        VeryHot = 30,
        Snowy = -4,
        Sunny = 23
    }
}
