using System;

namespace Inheritance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SeedPlants splants = new SeedPlants();
            // splants.Nutrition();
            // splants.Respiration();
            // splants.Excretion();
            // splants.Photosynthesis();
            splants.SeedReproduction();

            Console.WriteLine("************");

            Birds bird = new Birds();
            // bird.Nutrition();
            // bird.Respiration();
            // bird.Excretion();
            // bird.Adaptation();
            bird.ToFly();

            Console.WriteLine("************");

            
        }
    }
}