using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var oracleConnection = new OracleConnection("com.oracle.com",new TimeSpan(1,2,3));
            var sqlConnection = new SqlConnection("com.sql.com", new TimeSpan(1, 2, 3));

            //DbConnection connection1 = oracleConnection;
            //DbConnection connection2 = sqlConnection;

            //connection1.Opened();
            //connection1.Closed();

            //connection2.Opened();
            //connection2.Closed();

            DbCommand dbCommand = new DbCommand(new SqlConnection("com.sql.connection",new TimeSpan(1,2,3)),"Instruction1");
            DbCommand dbCommand2 = new DbCommand(new OracleConnection("com.oracle.connection", new TimeSpan(1, 2, 3)), "Instruction2");
            DbCommand dbCommand3 = new DbCommand(null, "Instruction3");

            dbCommand.Execute();
            dbCommand2.Execute();
            dbCommand3.Execute();




        }
    }
}
