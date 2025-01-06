using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ConsoleApp1
{
    internal interface IMyInnterface2
    {

        DataTable selectall();
        DataTable selectrow(int personalid);
        bool inserttotable(int personalid, string name, string family, string town, int age);
        bool deletfromtable(int personalid );
        bool updatetable(int personalid, string name, string family, string town, int age);


    }
}
