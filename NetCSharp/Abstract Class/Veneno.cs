using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class Veneno : ICars
    {
        public int HorsePower()
        {
            return 400;
        }
        public CarColor StandardColor()
        {
            return CarColor.White;
        }

        public Brand WhichBrand()
        {
            return Brand.Lamborghni;
        }
    }
}