using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_handbook.Models
{
    internal abstract class RadioComponent
    {
        protected string Name;
        protected string Type;
        protected double Price;

        public RadioComponent(string name, string type, double price)
        {
            Name = name;
            Type = type;
            Price = price;
        }
    }
}