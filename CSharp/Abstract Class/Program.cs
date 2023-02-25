using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("****** ETron ******");
            ETron etron = new ETron();
            Console.WriteLine(etron.WhichBrand().ToString());
            Console.WriteLine(etron.HorsePower().ToString());
            Console.WriteLine(etron.StandardColor().ToString());
            Console.WriteLine();

            Console.WriteLine("****** Daytona ******");
            Daytona daytona = new Daytona();
            Console.WriteLine(daytona.WhichBrand().ToString());
            Console.WriteLine(daytona.HorsePower().ToString());
            Console.WriteLine(daytona.StandardColor().ToString());
            Console.WriteLine();

            Console.WriteLine("****** Veneno ******");
            Veneno veneno = new Veneno();
            Console.WriteLine(veneno.WhichBrand().ToString());
            Console.WriteLine(veneno.HorsePower().ToString());
            Console.WriteLine(veneno.StandardColor().ToString());

            Console.WriteLine("****** Abstract ******");
            NewETron netron = new NewETron();
            Console.WriteLine(netron.WhichBrand().ToString());
            Console.WriteLine(netron.HorsePower().ToString());
            Console.WriteLine(netron.StandardColor().ToString());

            Console.WriteLine("***********************");
            NewDaytona ndaytona = new NewDaytona();
            Console.WriteLine(ndaytona.WhichBrand().ToString());
            Console.WriteLine(ndaytona.HorsePower().ToString());
            Console.WriteLine(ndaytona.StandardColor().ToString());
        }
    }
}