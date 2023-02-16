using System;

namespace Inheritance
{
    public class Animals : LivingBeings
    {
        protected void Adaptation(){
            Console.WriteLine("Animals are currently adapting to each other.");
        }
    }

    public class Reptiles : Animals
    {
        public Reptiles(){
            base.Adaptation();
            base.Nutrition();
            base.Respiration();
            base.Excretion();
        }

        public void ReptilesCrawling(){
            Console.WriteLine("Reptiles crawl to move.");
        }
    }

    public class Birds : Animals
    {
        public Birds(){
            base.Adaptation();
            base.Nutrition();
            base.Respiration();
            base.Excretion();
        }

        public void ToFly(){
            Console.WriteLine("Birds fly.");
        }
    }
}