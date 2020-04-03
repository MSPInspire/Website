using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Team
    {
        public Team(string firstname, string secondname, string picture, string subtitle)
        {
            FirstName = firstname;
            SecondName = secondname;
            Picture = picture;
            Subtitle = subtitle;
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string secondName;

        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }

        private string subtitle;

        public string Subtitle
        {
            get { return subtitle; }
            set { subtitle = value; }
        }
       

        public string Picture
        {
            get { return picture; }
            set { picture = value; }
        }






    }
}
