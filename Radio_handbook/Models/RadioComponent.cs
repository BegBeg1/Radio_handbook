using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_handbook.Models
{
    public class RadioComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Brand {  get; set; }
        public double Resistance { get; set; }
        public double Voltage { get; set; }
        public double Сurrent { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}
