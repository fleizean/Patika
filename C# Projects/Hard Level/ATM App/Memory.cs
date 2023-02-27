using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace atmapp
{
    public class Memory
    {
        GetLocalIP ip = new GetLocalIP();
        List<User> _user;
        public Memory()
        {
            _user = new List<User>
            {
                new User {
                    _UserID = 1,
                    _Password = "test",
                    _FirstName = "Enes",
                    _LastName = "Yağız",
                    _Money = 300,
                    _LastTransactionDate = new DateTime(2023, 02, 27),
                    _UserCreationDate = new DateTime(2008, 11, 23)
                },
                new User {
                    _UserID = 2,
                    _Password = "123",
                    _FirstName = "Fikret",
                    _LastName = "Özbilek",
                    _Money = 250,
                    _LastTransactionDate = new DateTime(2023, 01, 21),
                    _UserCreationDate = new DateTime(2009, 12, 13)
                }
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
        public User GetByUser(int userid)
        {
            return _user.Find(x => x._UserID == userid);
        }
    }
}