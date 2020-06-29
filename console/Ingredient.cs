using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    class Ingredient
    {
        public string iname;
        public string itype;
        public int weight;
        public string unit;
        public string description;
        public int price;

        public Ingredient(string aname, string atype, int aweight, string aunit, string adescription, int aprice )
        {
            iname = aname;
            itype = atype;
            weight = aweight;
            unit = aunit;
            description = adescription;
            price = aprice;
        }
    }
}
