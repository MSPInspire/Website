using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Teams
    {
        public List<Team> teams = new List<Team>();
        public Teams()
        {
            
            Team salman = new Team("Salman", "Chishti", "incoming Microsoft intern", "https://pbs.twimg.com/profile_images/1240958813114699777/fuqzzP9o_400x400.png");
            Team dawood = new Team("Dawood", "Iddris", "Co-founder of Techloud, MSP", "https://pbs.twimg.com/profile_images/1243281133128867841/qo8YAswd_400x400.jpg");
            Team sabiha = new Team("Sabiha", "Shaik", "Co-founder of zuvmeco, MSP ", "https://pbs.twimg.com/profile_images/1237997999848112128/afh2nqnU_400x400.jpg");
            Team sunder = new Team("Sundereshwar", "Kodi", "MSP", "https://pbs.twimg.com/profile_images/996210938746372096/FcxJdvpu_400x400.jpg");
            teams.Add(salman);
            teams.Add(dawood);
            teams.Add(sabiha);
            teams.Add(sunder);

        }
    }
}
