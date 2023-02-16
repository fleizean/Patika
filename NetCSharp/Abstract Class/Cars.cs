using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public abstract class Cars
    {
        public int HorsePower(){
            return 400;
        }

        public virtual CarColor StandardColor(){
            return CarColor.White;
        }

        public abstract Brand WhichBrand();
    }
}