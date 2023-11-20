using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    public class Party
    {
        public Adventurer Leader;

        public Party()
        {
            Leader = null;
        }

        public void AddAdventurer(string name, int level)
        {
            Adventurer newAdventurer = new Adventurer(name, level);
        }
    }
}
