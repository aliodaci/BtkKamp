using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.Add();
            database.Delete();


            Database database1 = new SqlServer();
            database1.Add();
            database1.Delete();

            
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Add by default");
        }

        public abstract void Delete();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Database deleted sqlserver");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Database deleted Oracle");
        }
    }
}
