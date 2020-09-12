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
        //public string iname;
        //public string itype;
        //public int weight;
        //public string unit;
        //public string description;
        //public int price;

        //public Ingredient(string aname, string atype, int aweight, string aunit, string adescription, int aprice )
        //{
        //    iname = aname;
        //    itype = atype;
        //    weight = aweight;
        //    unit = aunit;
        //    description = adescription;
        //    price = aprice;
        //}

        private string name;
        private string type;
        private int weight;
        private string unit;
        private string description;
        private int price;

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int Weight { get => weight; set => weight = value; }
        public string Unit { get => unit; set => unit = value; }
        public string Description { get => description; set => description = value; }
        public int Price { get => price; set => price = value; }

        public void SomeMethod(int someParam)
        {

        }

        public Ingredient(string name, string type, int weight, string unit, string description, int price)
        {
            this.Name = name;
            this.Type = type;
            this.Weight = weight;
            this.Unit = unit;
            this.Description = description;
            this.Price = price;

        }
    }

    
}
