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
            Adventurer adventurer = new Adventurer(name, level);

            if (Leader == null)
            {
                Leader = adventurer;
            }
            else
            {
                Adventurer current = Leader;

                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = adventurer;
            }
        }

        public void DisplayParty()
        {
            Adventurer current = Leader;
            while (current.Next != null)
            {
                Console.WriteLine($"{current.Name} (Level {current.Level})");

                current = current.Next;
            }

            Console.WriteLine($"{current.Name} (Level {current.Level})");
        }
    }
}
