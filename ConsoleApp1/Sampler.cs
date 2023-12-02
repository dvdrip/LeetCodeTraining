using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Sampler
    {
        public int MyProperty { get; set; }

        public Sampler(string myItem)
        {
            MyProperty = Convert.ToInt32(myItem);
        }

        public int GetSample()
        {
            return MyProperty;
        }
    }
}
