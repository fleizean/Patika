using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace votingapp
{
    public class ContextUser
    {
        Error error = new Error();
        Memory memory = new Memory();

        public bool ContextControl(string username, string password)
        {
            User? user = memory.GetByUser(username); // GetByUser metodumuz ile kullanıcımızın verilerini alıyoruz

            if(user._Password == password) // parola eşleşimini kontrol ediyoruz
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddUser(User user)
        {
            int i = 0;
            List<User> nuser = memory.GetUserList();
            foreach (User item in nuser)
            {
                if (item._UserName == user._UserName)
                    i++;
            } 
            if(i == 0)
            {
                User newUser = new User
                {
                    _ID = nuser.Count + 1,
                    _UserName = user._UserName,
                    _Password = user._Password,
                    _FirstName = user._FirstName,
                    _LastName = user._LastName,
                    _UserCreationDate = user._UserCreationDate,
                };
                memory.Add(newUser);
                return true;
            }
            else
            {
                error.SystemError(user._UserName);
                return false;
            }
        }
    }
}