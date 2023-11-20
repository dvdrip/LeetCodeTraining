using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    public class Adventurer
    {
        public string Name;
        public int Level;
        public Adventurer Next;

        public Adventurer(string name, int level)
        {
            Name = name;
            Level = level;
            Next = null;
        }
    }
}
