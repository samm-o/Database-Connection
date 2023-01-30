using System;
namespace DBconnection
{
    public class DbCommand
    {
        public string Instruction { get; set; }
        public DbConnection ConnectionInstance { get; set; }
        public DbCommand(DbConnection connectionInstance, string instruction)
        {
            ConnectionInstance = connectionInstance;

            if (connectionInstance == null)
            {
                Console.WriteLine("Invalid Input.");
                Environment.Exit(0);
            }

            if (string.IsNullOrEmpty(connectionInstance.ConnectionString))
            {
                Console.WriteLine("Connection string cannot be null or empty.");
                Environment.Exit(0);
            }

            Instruction = instruction;

            if (string.IsNullOrEmpty(instruction))
            {
                Console.WriteLine("Instruction cannot be null or empty.");
                Environment.Exit(0);
            }
        }
        public void Execute()
        {
            ConnectionInstance.OpenTimeOut();
            Console.WriteLine(Instruction);
            ConnectionInstance.Close();
        }
        
    }
}
