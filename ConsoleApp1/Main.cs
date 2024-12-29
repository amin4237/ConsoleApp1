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
        void IMyInnterface2.HiUser(string name)
        {
            Console.WriteLine($"Hell dear {name} ");
        }


        string name { get { return _name; } set { _name = value; } }

        public Main(string name) { Console.WriteLine("hello hello"); }
    }
}
