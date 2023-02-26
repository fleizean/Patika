using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace votingapp
{
    public class User
    {
        public int _ID { get; set; }
        public string _UserName { get; set; }
        public string _Password { get; set; }
        public string? _FirstName { get; set; }
        public string? _LastName { get; set; }
        public DateTime? _UserCreationDate { get; set; }
    }
}