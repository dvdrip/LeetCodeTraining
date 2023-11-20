using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    public class Party
    {
        public Adventurer member;

        public Party()
        {
            member = null;
        }

        public void AddAdventurer(string name, int level)
        {
            Adventurer adventurer = new Adventurer(name, level);

            if (member == null)
            {
                member = adventurer;
            }
            else
            {
                Adventurer current = member;

                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = adventurer;
            }
        }

        public void DisplayParty()
        {
            Adventurer current = member;
            while (current != null)
            {
                Console.WriteLine($"{current.Name} (Level {current.Level})");

                current = current.Next;
            }
        }
    }
}
