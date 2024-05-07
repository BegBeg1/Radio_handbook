using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_handbook.Models
{
    public class Handbook
    {
        public List<Resistor> Resistors { get; set; }
        public Handbook() 
        {
            for(int i = 1; 1 <= 10; i++)
            {
                Resistors = new List<Resistor>();
                var r = new Resistor();
                r.Id = i;
                r.Name = $"resistor{i}";
                r.Description = $"decripton{i}";
                r.R = i;
                Resistors.Add(r);
            }
        }

        internal List<Resistor> Search(string name, string r)
        {
            return Resistors;
        }
    }
}
