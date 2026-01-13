using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXE7
{
    class Women
    {
        public string FirstName;
        public string LastName;
        public string City;
        public int Kids;

        public Women(string firstName, string lastName, string city, int kids)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;
            this.Kids = kids;
        }
    }

}
