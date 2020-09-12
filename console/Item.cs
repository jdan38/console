 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    class Item
    {
        private string name;
        private string type;
        private int weight;
        private string unit;
        private string description;
        private int price;
        private int qty;




        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int Weight { get => weight; set => weight = value; }
        public string Unit { get => unit; set => unit = value; }
        public string Description { get => description; set => description = value; }
        public int Price { get => price; set => price = value; }
        public int Qty { get => qty; set => qty = value; }


        public Item(string name, string type, int weight, string unit, string description, int price, int qty)
        {
            this.Name = name;
            this.Type = type;
            this.Weight = weight;
            this.Unit = unit;
            this.Description = description;
            this.Price = price;
            this.Qty = qty;
        }
    }
}
