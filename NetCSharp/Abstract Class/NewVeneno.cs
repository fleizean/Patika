using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class NewVeneno : Cars
    {
        public override Brand WhichBrand()
        {
            return Brand.Lamborghni;
        }
    }
}