using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // InterfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = { new OracleCustomerDal(), new SqlServerCustomerDal(),new MysqlCustomerDal() };
            foreach (var item in customerDals)
            {
                item.Add();
            }
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FisrtName = "Engin",
                LastName = "Demiroğ",
                Address = "Ankara"
            };

            Student student = new Student
            {
                Id = 1,
                FisrtName = "Derin",
                LastName = "Demiroğ",
                Deparment = "Computer Science"
            };

            personManager.Add(customer);
            personManager.Add(student);
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FisrtName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FisrtName { get; set; }
        public string LastName { get ; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FisrtName { get; set; }
        public string LastName { get; set; }

        public string Deparment { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FisrtName);
        }
    }
}
