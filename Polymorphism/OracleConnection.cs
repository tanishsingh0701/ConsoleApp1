using System;

namespace Polymorphism
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString, TimeSpan time) : base(connectionString, time)
        {
            if(connectionString==null)
                throw new NotImplementedException();
        }

        public override void Closed()
        {
            System.Console.WriteLine("OracleConnection Closed");
        }

        public override void Opened()
        {
            System.Console.WriteLine("OracleConnection Opened");
        }
    }
}
