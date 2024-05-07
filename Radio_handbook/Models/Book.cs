using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_handbook.Models
{
    public class Book
    {
        public string Owner { get; set; }
        public Person[] Persons { get; set; }
        public Book(int n) {
            Persons = new Person[n];
            for (int i = 0; i < n; i++)
            {
                Persons[i] = new Person { Address = $"Address{i}", Name = $"Name{i}" };
            }
        }
    }
}
