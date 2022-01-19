using System;

namespace Polymorphism
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString, TimeSpan time) : base(connectionString, time)
        {
        }

        public override void Closed()
        {
            Console.WriteLine("SqlConnection Closed");
        }

        public override void Opened()
        {
            Console.WriteLine("SqlConnection Opened");
        }
    }
}
