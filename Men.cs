using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE7
{
    class Men
    {
        public string FirstName;
        public string LastName;
        public string City;
        public int Distance;

        public Men(string firstName, string lastName, string city, int distance)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;
            this.Distance = distance;
        }
    }
}
