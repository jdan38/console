 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    class Item
    {
        public string iname;
        public string itype;
        public int weight;
        public string unit;
        public string description;
        public int price;
        public int qty;

        public Item(string aname, string atype, int aweight, string aunit, string adescription, int aprice, int aqty)
        {
            iname = aname;
            itype = atype;
            weight = aweight;
            unit = aunit;
            description = adescription;
            price = aprice;
            qty = aqty;
        }
 
    }
}
