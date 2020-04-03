using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Teams
    {
       
        public Teams()
        {
            List<Team> teams = new List<Team>();
            Team salman = new Team("Salman", "Chishti", "something", "incoming Microsoft intern");
        }
    }
}
