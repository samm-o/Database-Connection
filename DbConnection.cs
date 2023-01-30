using System;
using System.Threading.Tasks;

namespace DBconnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }
        
        public abstract void Open();
        public abstract void Close();
        public abstract void OpenTimeOut();

    }
}
