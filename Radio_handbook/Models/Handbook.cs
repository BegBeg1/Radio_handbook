﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_handbook.Models
{
    public class Handbook
    {
        public List<RadioComponent> Resistors { get; set; }
        public Handbook() 
        {
            for(int i = 1; 1 <= 10; i++)
            {
                Resistors = new List<RadioComponent>();
                var r = new RadioComponent();
                r.Id = i;
                r.Name = $"resistor{i}";
                r.Description = $"decripton{i}";
                r.R = i;
                Resistors.Add(r);
            }
        }

        internal List<RadioComponent> Search(string name, string r)
        {
            return Resistors;
        }
    }
}
