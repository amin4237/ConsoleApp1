using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Sayehello : IMyInterface
    {
        public void sayhello(string name)
        {
            Console.WriteLine($"hello {name} \n");
        }

        public void sum(int a, int b)
        {
            
        }
    }
}
