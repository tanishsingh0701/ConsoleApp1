using System;

namespace Polymorphism
{
    public abstract class DbConnection 
    {
        private string ConnectionString;
        private TimeSpan Timeout;
        public DbConnection(string connectionString,TimeSpan timeout)
        {
            if (connectionString == null)
                throw new Exception("Null Value is passed");
            ConnectionString = connectionString;
            Timeout = timeout;

        }

        public abstract void Closed();
        public abstract void Opened();

    }
}
