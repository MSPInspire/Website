using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Teams
    {
        static List<Team> teams = new List<Team>()
        {
            new Team
            {
                FirstName = "Salman",
                SecondName = "Chishti",
                Picture = "https://pbs.twimg.com/profile_images/1240958813114699777/fuqzzP9o_400x400.png",
                Subtitle = "Incoming Microsoft Intern, MSP"
            },
            new Team
            {
                FirstName = "Dawood",
                SecondName = "Iddris",
                Picture = "https://pbs.twimg.com/profile_images/1243281133128867841/qo8YAswd_400x400.jpg",
                Subtitle = "Co-founder of techloud, MSP"
            },
            new Team
            {
                FirstName = "Sabiha",
                SecondName = "Shaik",
                Picture = "https://pbs.twimg.com/profile_images/1237997999848112128/afh2nqnU_400x400.jpg",
                Subtitle = "Co-founder of zuvmeco, MSP"
            }
        };
    }
}
