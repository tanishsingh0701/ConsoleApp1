using System;

namespace Polymorphism
{
    public class DbCommand 
    {
        private string _instruction;
        private DbConnection connect;
        public DbCommand(DbConnection connection,string instruction)
        {
            if(connection==null)
                throw new Exception("Null Value is passed");
            _instruction = instruction;
            connect = connection;

        }

        public void Execute() 
        {
            connect.Opened();
            Console.WriteLine("Executing Instruction: "+_instruction);
            connect.Closed();
        }

    }
}
