using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace Person_Example
{
    class Program
    {
        


        static void Main(string[] args)
        {

            
            for (int i = 0; i < 3; i++)
            {

                
                Main m1 = new Main($"user number {i} :");
                m1.name = Convert.ToString(Console.ReadLine());
                m1.HiUser(m1.name);
                

                List<Main> list1 = new List<Main>();
                list1.Add(m1);
                Console.ReadKey();

              
            }
            

        }

    }
}
