using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.SqlTypes;


namespace ConsoleApp1
{
    
    public class services: IMyInnterface2
    {
        
        private string connstring = "Data Source=.;Initial Catalog=Market;Integrated Security=true";

        public bool deletfromtable(int personalid)
        {
            return true;
        }

        public bool inserttotable(int personalid, string name, string family, string town, int age)
        {
            return true;
            
        }

        public DataTable selectall()
            
        {
            sqlconnection sqconn =new sqlconnection(connstring);
            DataTable dt1 = new DataTable();
            DataAdapter da1 = new DataAdapter("select * from Person",sqconn);

            da1.Fill(dt1);
            return dt1;
           
        }

        public DataTable selectrow(int personalid)
        {
            
        }

        public bool updatetable(int personalid)
        {
           
        }

        bool IMyInnterface2.updatetable(int personalid, string name, string family, string town, int age)
        {
            throw new NotImplementedException();
        }
    }


}
