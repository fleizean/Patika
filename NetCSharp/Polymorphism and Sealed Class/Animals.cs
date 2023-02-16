using System;

namespace Inheritance
{
    public class Animals : LivingBeings
    {
        protected void Adaptation(){
            Console.WriteLine("Animals are currently adapting to each other.");
        }

        public override void StimulusResponse(){
            base.StimulusResponse();
            Console.WriteLine("The animals reacted to touch..");
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
            base.StimulusResponse();
        }

        public void ToFly(){
            Console.WriteLine("Birds fly.");
        }
    }
}