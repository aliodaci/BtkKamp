using System;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();

            MysqlServer mysqlServer = new MysqlServer();
            mysqlServer.Add();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Add by default");
        }
        public void Deleted()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class SqlServer:Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code");
            //base.Add();
        }
    }

    class MysqlServer:Database
    {

    }
}
