using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zoo
{
    public class Animal
    {
        private string _KindType;
        private int _Weight;
        private int _Age;

        public Animal(string kindtype, int weight, int age)
        {
            this._KindType = kindtype;
            this._Weight = weight;
            this._Age = age;
        }
    }
}