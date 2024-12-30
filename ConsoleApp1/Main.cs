using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Main : IMyInnterface2
    {

        private string _name;


        public string name { get { return _name; } set { _name = value; } }

        public Main(string payam) { Console.WriteLine(payam); }
        public void HiUser(string name)
        {
                      Console.WriteLine($"Hello dear {name} ");
        }
    }
}
