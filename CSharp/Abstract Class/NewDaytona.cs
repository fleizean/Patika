using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class NewDaytona : Cars
    {
        public override Brand WhichBrand()
        {
            return Brand.Ferrari;
        }

        public override CarColor StandardColor()
        {
            return CarColor.Red;
        }
    }
}