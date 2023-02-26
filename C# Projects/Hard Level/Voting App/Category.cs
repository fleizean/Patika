using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace votingapp
{
    public class Category
    {
        public int _ID { get; set; }
        public string _Tittle { get; set; }
        public int _VoteCount { get; set; }
        public string _LastVoter { get; set; }
    }
}