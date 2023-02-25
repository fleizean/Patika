using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zoo
{
    public abstract class Animal
    {
        private string _KindType;
        private int _Weight;
        private int _Age;

        public Animal(string kindtype, int weight, int age)
        {
            this._KindType = kindtype;
            if(weight < 0)
                this._Weight = 1;
            else
                this._Weight = weight;
            if(age < 0) 
                this._Age = 0;
            else
                this._Age = age;
        }
        public string KindType {
        get { return _KindType; }
        set { _KindType = value; }
        }
        public int Weight {
        get { return _Weight; }
        set { _Weight = value; }
        }
        public int Age {
        get { return _Age; }
        set { _Age = value; }
        }

        public abstract double GetDosage();
        public abstract void GetFeedSchedule();
    }

    /* Equine */
    public class Horse : Animal
    {
        public Horse(string name, int weight, int age) : base(name, weight, age) {}

        public override double GetDosage() {
            return (2.1);
        }

        public override void GetFeedSchedule() {
            Console.WriteLine("*********** FEED SCHEDULE ***********");
            Console.WriteLine("Mon: 3");
            Console.WriteLine("Tue: 2");
            Console.WriteLine(value: "Wed: 1");
            Console.WriteLine("Thu: 2");
            Console.WriteLine("Fri: 3");
            Console.WriteLine("Sat: 1");
            Console.WriteLine("Sun: 2");
            Console.WriteLine("*************************************");
        }
    }

    public class Lion : Animal
    {
        public Lion(string name, int weight, int age) : base(name, weight, age) {}
        public override double GetDosage() {
            return (2.1);
        }

        public override void GetFeedSchedule() {
            Console.WriteLine("*********** FEED SCHEDULE ***********");
            Console.WriteLine("Mon: 3");
            Console.WriteLine("Tue: 2");
            Console.WriteLine(value: "Wed: 1");
            Console.WriteLine("Thu: 2");
            Console.WriteLine("Fri: 3");
            Console.WriteLine("Sat: 1");
            Console.WriteLine("Sun: 2");
            Console.WriteLine("*************************************");
        }
    }

    /* Feline */
        public class Tiger : Animal
    {
        public Tiger(string name, int weight, int age) : base(name, weight, age) {}

        public override double GetDosage() {
            return (2.1);
        }

        public override void GetFeedSchedule() {
            Console.WriteLine("*********** FEED SCHEDULE ***********");
            Console.WriteLine("Mon: 3");
            Console.WriteLine("Tue: 2");
            Console.WriteLine(value: "Wed: 1");
            Console.WriteLine("Thu: 2");
            Console.WriteLine("Fri: 3");
            Console.WriteLine("Sat: 1");
            Console.WriteLine("Sun: 2");
            Console.WriteLine("*************************************");
        }
    }

    public class Zebra : Animal
    {
        public Zebra(string name, int weight, int age) : base(name, weight, age) {}
        public override double GetDosage() {
            return (2.1);
        }

        public override void GetFeedSchedule() {
            Console.WriteLine("*********** FEED SCHEDULE ***********");
            Console.WriteLine("Mon: 3");
            Console.WriteLine("Tue: 2");
            Console.WriteLine(value: "Wed: 1");
            Console.WriteLine("Thu: 2");
            Console.WriteLine("Fri: 3");
            Console.WriteLine("Sat: 1");
            Console.WriteLine("Sun: 2");
            Console.WriteLine("*************************************");
        }
    }
    /* Rodent */
        public class Beaver : Animal
    {
        public Beaver(string name, int weight, int age) : base(name, weight, age) {}

        public override double GetDosage() {
            return (2.1);
        }

        public override void GetFeedSchedule() {
            Console.WriteLine("*********** FEED SCHEDULE ***********");
            Console.WriteLine("Mon: 3");
            Console.WriteLine("Tue: 2");
            Console.WriteLine(value: "Wed: 1");
            Console.WriteLine("Thu: 2");
            Console.WriteLine("Fri: 3");
            Console.WriteLine("Sat: 1");
            Console.WriteLine("Sun: 2");
            Console.WriteLine("*************************************");
        }
    }

    public class Rat : Animal
    {
        public Rat(string name, int weight, int age) : base(name, weight, age) {}
        public override double GetDosage() {
            return (2.1);
        }

        public override void GetFeedSchedule() {
            Console.WriteLine("*********** FEED SCHEDULE ***********");
            Console.WriteLine("Mon: 3");
            Console.WriteLine("Tue: 2");
            Console.WriteLine(value: "Wed: 1");
            Console.WriteLine("Thu: 2");
            Console.WriteLine("Fri: 3");
            Console.WriteLine("Sat: 1");
            Console.WriteLine("Sun: 2");
            Console.WriteLine("*************************************");
        }
    }
}