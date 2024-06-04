using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Radio_handbook.Models
{
    public class Handbook
    {
        
        public const string PATH = "data.txt";
        [JsonInclude]
        public List<RadioComponent> RadioComponents;
        public Handbook(List<RadioComponent> radioComponents)
        {
            this.RadioComponents = radioComponents;
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
        public void SaveData()
        {
            var jsonString = JsonSerializer.Serialize(this);
            File.WriteAllText(PATH, jsonString);
        }
        public static Handbook LoadData()
        {
            if (!File.Exists(PATH))
            {
                return new Handbook([]);
            }
            return JsonSerializer.Deserialize<Handbook>(File.ReadAllText(PATH))!;
        }
    }
}
