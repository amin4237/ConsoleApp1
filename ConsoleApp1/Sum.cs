using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Sum : IMyInterface
    {
        public int _a;
        public int _b;
        private string _family;
        public void sayhello(string name)
        {
            Console.WriteLine($"hellooo \n");
        }

        public void sum(int a, int b)
        {
            Console.WriteLine($"sum of {a} and {b} is {a + b} \n");
        }

        //public Sum(int a, int b) 
        //{
        //    this._a = a;
        //    this._b = b;
        //}
        //static Sum()
        //{
        //    Console.WriteLine("static constructor of Sum class");
        //}
        public string _family
        {
            get
            { return _family; }
            set 
            { _family = value; }
        }

    }



    }
}
