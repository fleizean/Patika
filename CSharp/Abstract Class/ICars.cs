using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public interface ICars
    {
        int HorsePower();

        Brand WhichBrand();

        CarColor StandardColor();
    }
}