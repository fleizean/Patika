using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class Daytona : ICars
    {
        public int HorsePower()
        {
            return 325;
        }
        public CarColor StandardColor()
        {
            return CarColor.Orange;
        }

        public Brand WhichBrand()
        {
            return Brand.Ferrari;
        }
    }
}