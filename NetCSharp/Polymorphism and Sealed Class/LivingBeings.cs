using System;

namespace Inheritance
{
    //public sealed class LivingBeings -> if i do i can't access it from anywhere
    public class LivingBeings
    {
        protected void Nutrition(){
            Console.WriteLine("Living beings eating right now.");
        }
        
        protected void Respiration(){
            Console.WriteLine("Living beings breathes right now.");
        }

        protected void Excretion(){
            Console.WriteLine("Living beings excrete right now.");
        }

        public virtual void StimulusResponse(){
            Console.WriteLine("Living beings responded to stimuli.");
        }
    }
}