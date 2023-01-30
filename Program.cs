using System;

namespace DBconnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbcommand = new DbCommand(CommandType(), "Instruction Test");
            dbcommand.Execute();
        }
        public static DbConnection CommandType()
        {
            Console.Write("Type {0} for a sql command and {1} for an oracle command: ", "s", "o");
            var input = Console.ReadLine();
            if (input == "s" || input == "S")
            {
                return new SqlConnection("SQL", TimeSpan.FromSeconds(10));
            }
            if (input == "o" || input == "O")
            {
                return new OracleConnection("ORACLE", TimeSpan.FromSeconds(10));
            }
            else
            {
                return null;
            }
        }
    }
}
