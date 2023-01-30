using System;
using System.Threading;

namespace DBconnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connection, TimeSpan timeout)
        {
            ConnectionString = connection;
            Timeout = timeout;
        }

        public override void OpenTimeOut()
        {
            Thread t = new Thread(Open);
            t.Start();
            if (!t.Join(Timeout))
            {
                Console.Clear();
                Console.WriteLine("Timeout.");
                Environment.Exit(0);
            }
        }

        public override void Open()
        {
            Console.Write("Please type Oracle connection string: ");
            var input = Console.ReadLine();

            if (input == ConnectionString)
            {
                Console.WriteLine("Oracle Connection Open.");
            }
            else
            {
                Console.WriteLine("Incorrect bridge.");
                Environment.Exit(0);
            }
         }

        public override void Close()
        {
            Console.WriteLine("Oracle Connection Closed.");
        }
    }
}
