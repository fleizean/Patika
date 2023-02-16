using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class ETron : ICars
    {
        public int HorsePower()
        {
            return 350;
        }
        public CarColor StandardColor()
        {
            return CarColor.Green;
        }

        public Brand WhichBrand()
        {
            return Brand.Audi;
        }
    }
}