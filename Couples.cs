using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE7
{
    class Couples
    {
        public string ManName { get; set; }
        public string WomanName { get; set; }
        public Couples(string manName, string womanName)
        {
            ManName = manName;
            WomanName = womanName;
        }
        // Override ToString() so it displays nicely in list boxes or rich text boxes
        public override string ToString()
        {
            return ($"{ManName} & {WomanName}");
        }
    }
}
