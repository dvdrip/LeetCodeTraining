using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Suikoden
    {
        public string Hero { get; set; }
        public int Level { get; set; }
        public Dictionary<int, Weapon> Weapon { get; set; } 
    }
}
