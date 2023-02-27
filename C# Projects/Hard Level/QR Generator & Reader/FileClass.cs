using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qrcodeapp
{
    public class FileClass
    {
        public string GetCurrentDirectory()
        {
            string path = Directory.GetCurrentDirectory();//Exe nin bulunduğu dizin i getirme
            return (path);
        }
    }
}