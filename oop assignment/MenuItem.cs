using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment
{
    public class MenuItem
    {
        public int Id { get; set; } 
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }

        public MenuItem() { }

        public MenuItem(string itemName, decimal price, bool available)
        {
            ItemName = itemName;
            Price = price;
            Available = available;
        }

        public override string ToString()
        {
            return $"{ItemName} - {Price:C} - {(Available ? "Available" : "Not Available")}";
        }
    }
}

