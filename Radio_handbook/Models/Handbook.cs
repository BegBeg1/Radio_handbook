using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_handbook.Models
{
    public class Handbook
    {
        public List<RadioComponent> Components { get; set; }
        public Handbook() 
        {
            for(int i = 1; 1 <= 10; i++)
            {
                var Components = new List<RadioComponent>();
                var r = new RadioComponent();
                r.Id = i;
                r.Name = $"resistor{i}";
                r.Type = $"type{i}";
                r.Description = $"decripton{i}";
                r.Resistance = i;
                r.Capacitance = i;
                r.Inductance = i;
                Components.Add(r);
            }
        }

        //internal List<RadioComponent> Search(string name, string r)
        //{
        //    return Components;
        //}
    }
}
