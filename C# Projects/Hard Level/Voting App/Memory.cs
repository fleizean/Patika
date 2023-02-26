using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace votingapp
{
    public class Memory
    {
        List<User> _user;
        public Memory()
        {
            _user = new List<User>
            {
                new User { _ID = 1444, _UserName = "fleizean", _Password = "votingapp", _FirstName = "Enes", _LastName = "Yağız", _UserCreationDate = new DateTime(2002, 07, 27)},
                new User { _ID = 1, _UserName = "dostum", _Password = "123", _FirstName = "Bahadır", _LastName = "Çimen", _UserCreationDate = new DateTime(2000, 01, 21)},
            };
        }

        public void Add(User newUser)
        {
            _user.Add(newUser);
        }
        public List<User> GetUserList()
        {
            return _user;
        }
        public User GetByUser(string username)
        {
            return _user.Find(x => x._UserName == username);
        }
    }
}