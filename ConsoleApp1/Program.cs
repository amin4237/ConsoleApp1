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
            try
            {

                Console.WriteLine("sum(1) or sayhello(2)? \n");
                int state = Convert.ToInt32(Console.ReadLine());
                if (state == 1)
                {
                                        Console.WriteLine("enter first num");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter second num");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Sum sum1 = new Sum(a,b);
                    sum1.sayhello("amin");
                    sum1.sum(a, b);
                }
                else if (state == 2)
                {
                    Console.WriteLine("what is your name? \n");
                    Sayehello sayhello1 = new Sayehello();
                    string str1 = Console.ReadLine();
                    sayhello1.sayhello(str1);

                }
            }
            catch
            {
                Console.WriteLine("mistake in income \n");
            }



            //Baby bb = new Baby("amin", "reza", 18);
           
            //try
            //{
                

            //    Console.WriteLine("enter your number of person");
            //    int NumOfPerson = Convert.ToInt32(Console.ReadLine());
            //    Person[] persons = new Person[NumOfPerson];

            //    for (int i = 0; i < NumOfPerson; i++)
            //    {


            //        Console.WriteLine($"enter name of number {i + 1} ");
            //        string name = Console.ReadLine();

            //        Console.WriteLine($"enter family of number {i + 1} ");
            //        string family = Console.ReadLine();

            //        Console.WriteLine($"enter age of number {i + 1} ");
            //        int age = Convert.ToInt32(Console.ReadLine());

            //        Person p = new ConsoleApp1.Person(name, family, age);

            //        persons[i] = p;

            //    }

            //    Console.WriteLine("for show all off persons \n\n");
            //    for (int i = 0; i < persons.Length; i++)
            //    {
            //        Console.WriteLine($"number of {i} is : {persons[i].Name} *** {persons[i].Family} *** {persons[i].Age}");
            //    }
            //    Console.ReadKey();


                

            //}
            //catch
            //{
            //    Console.WriteLine("enter valid");
            //}
        }

    }
}
