using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atmapp
{
    public class User
    {
        public int _UserID { get; set; }
        public string _Password { get; set; }
        public string? _FirstName { get; set; }
        public string? _LastName { get; set; }
        public int _Money { get; set; }
        public DateTime? _LastTransactionDate { get; set; }
        public DateTime? _UserCreationDate { get; set; } 
    }
}