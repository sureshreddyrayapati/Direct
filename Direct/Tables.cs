using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Direct
{
    public class Tables
    {
        public void Multiples(int b)
        {
            for(int i = 1;i<=10;i++)
            {
                Console.WriteLine($"{b} * {i} = {b}");
            }
        }
    }
}
