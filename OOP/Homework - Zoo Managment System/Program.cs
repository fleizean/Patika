using System;

namespace zoo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal horse = new Horse("Pinto", 500, 6);
            Animal lion = new Lion("Simba", 300, 8);
            Animal rat = new Rat("Remy", 2, 2);

            Console.WriteLine(horse.KindType + " weighs " + horse.Weight + " kg and needs " + horse.GetDosage() + " ml of medicine.");
            horse.GetFeedSchedule();

            Console.WriteLine(lion.KindType + " weighs " + lion.Weight + " kg and needs " + lion.GetDosage() + " ml of medicine.");
            lion.GetFeedSchedule();

            Console.WriteLine(rat.KindType + " weighs " + rat.Weight + " kg and needs " + rat.GetDosage() + " ml of medicine.");
            rat.GetFeedSchedule();
        }
    }
}