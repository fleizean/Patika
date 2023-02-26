using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace votingapp
{
    public class Error
    {
        public void SystemError(string username)
        {
            Console.WriteLine("A system error was encountered while creating the user named " + username);
            Environment.Exit(0);
        }
    }
}