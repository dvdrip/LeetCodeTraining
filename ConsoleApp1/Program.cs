using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            writeStuffFirst();
            writeStuffSecond();

            Class1 class1 = new Class1();
            var a = class1.sumNum(1, 2);

            Console.WriteLine(a);

            Console.ReadLine();
        }

        private static void writeStuffFirst()
        {
            Console.WriteLine("Hello");
            Class1 c1 = new Class1();
            c1.getSomething();
        }

        private static void writeStuffSecond()
        {
            Console.WriteLine("World");
            Class1 class1 = new Class1();
            class1.getNothing();
        }
    }
}
