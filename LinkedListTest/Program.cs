using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Party party = new Party();

            party.AddAdventurer("Claude", 255);
            party.AddAdventurer("Rena", 255);
            party.AddAdventurer("Ashton", 99);
            party.AddAdventurer("Dias", 99);
            party.AddAdventurer("Opera", 67);

            Console.WriteLine("Party members:");
            party.DisplayParty();

            Console.ReadLine();

        }
    }
}
