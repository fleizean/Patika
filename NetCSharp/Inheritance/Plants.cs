using System;

namespace Inheritance
{
    public class Plants : LivingBeings
    {
        protected void Photosynthesis(){
            Console.WriteLine("Plants are currently undergoing photosynthesis.");
        }
    }

    public class SeedPlants : Plants
    {
        public SeedPlants(){
            base.Photosynthesis();
            base.Nutrition();
            base.Respiration();
            base.Excretion();
        }

        public void SeedReproduction(){
            Console.WriteLine("Seeds reproductioning right now.");
        }
    }

    public class SeedlessPlant : Plants
    {
        public SeedlessPlant(){
            base.Photosynthesis();
            base.Nutrition();
            base.Respiration();
            base.Excretion();
        }

        public void Sporulation(){
            Console.WriteLine("Seeds sporulationing right now.");
        }
    }
}