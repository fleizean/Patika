using System;

namespace Inheritance
{
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
    }
}