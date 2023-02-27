using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atmapp
{
    public class Controller
    {
        Memory memory = new Memory();
        public bool UserController(int userid, string password)
        {
            User? user = memory.GetByUser(userid);
            if(user._Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}