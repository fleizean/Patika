using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApplication
{
    public class Board
    {
        public List<Card> ? ToDo { get; set; }
        public List<Card> ? Inprogress { get; set; }
        public List<Card> ? Done { get; set; }
    }
}