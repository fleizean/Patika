using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApplication
{
    public class Database
    {
        private static List<Card> _cards;
        private static List<User> _user;

        static Database()
        {
            _cards = new List<Card>()
            {
                new Card()
                {
                    Head = "Mobile",
                    Content = "Editing sqlmap",
                    Size = "XL",
                    Person = "Enes",
                    Status = "InProgress"
                },
                new Card()
                {
                    Head = "Backend",
                    Content = "Editing some files",
                    Size = "L",
                    Person = "Jack",
                    Status = "Done"
                },
                new Card()
                {
                    Head = "Testing",
                    Content = "Testing3",
                    Size = "S",
                    Person = "Daniel",
                    Status = "ToDo"
                }
            };
            _user = new List<User>()
            {
                new User()
                {
                    Name = "Enes",
                    Team = "Mobile",
                    ID = 1
                },
                new User()
                {
                    Name = "Jack",
                    Team = "Backend",
                    ID = 2
                },
                new User()
                {
                    Name = "Daniel",
                    Team = "Testing",
                    ID = 3
                }
            };
        }
        public static List<Card> Card => _cards;
        public static List<User> Person => _user;
    }
}