using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvparser
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsLiving { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
