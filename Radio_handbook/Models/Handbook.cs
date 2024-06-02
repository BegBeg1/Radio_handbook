﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_handbook.Models
{
    public class Handbook
    {
        public List<RadioComponent> RadioComponents { get; set; }
        public Handbook() 
        {
            RadioComponents = FillWithTestData(3);
        }

        public List<RadioComponent> FillWithTestData(int n)
        {
            var Components = new List<RadioComponent>();
            for (int i = 1; i <= n; i++)
            {
                Components.Add(new RadioComponent
                {
                    Id = i,
                    Name = $"Резистор{i}",
                    Type = "Резистор",
                    Resistance = i,
                    Capacitance = null,
                    Inductance = null,
                    Description = $"decripton{i}"
                });
            }
            for (int i = 1; i <= n; i++)
            {
                Components.Add(new RadioComponent
                {
                    Id = i,
                    Name = $"Котушка індуктивності{i}",
                    Type = "Котушка індуктивності",
                    Resistance = null,
                    Capacitance = null,
                    Inductance = i,
                    Description = $"decripton{i}"
                });
            }
            for (int i = 1; i <= n; i++)
            {
                Components.Add(new RadioComponent
                {
                    Id = i,
                    Name = $"Конденсатор{i}",
                    Type = "Конденсатор",
                    Resistance = null,
                    Capacitance = i,
                    Inductance = null,
                    Description = $"decripton{i}"
                });
            }
            return Components;
        }

        public List <RadioComponent> Search(string id, string name, string type, string resistance, 
                                            string capacitance, string inductance, string description)
        {
            var result = new List<RadioComponent>();
            foreach(var item in RadioComponents)
            {
                if (item.Id.ToString().Contains(id) &&
                    item.Name.Contains(name) &&
                    item.Type.Contains(type) &&
                    item.Resistance.ToString().Contains(resistance) &&
                    item.Capacitance.ToString().Contains(capacitance) &&
                    item.Inductance.ToString().Contains(inductance) &&
                    item.Description.Contains(description))
                {
                    result.Add(item);
                }
            }
            return result ;
        }
    }
}
