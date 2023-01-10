using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList citiesList = ArrayList();

            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            //Console.WriteLine(dictionary["table"]);
            //Console.WriteLine(dictionary["glass"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));

        }

        private static void List()  
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            //Console.WriteLine(cities.Contains("Ankara"));

            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, SurName = "Ali" });
            //customers.Add(new Customer { Id = 2, SurName = "Selin" });

            List<Customer> customers = new List<Customer>
            {
                new Customer{Id=1,SurName="Ali"},
                new Customer{Id=2,SurName="Selin"}
            };


            var customer1 = new Customer
            {
                Id = 3,
                SurName = "Cem"
            };
            customers.Add(customer1);
            customers.AddRange(new Customer[2]
            {
                new Customer{ Id=4,SurName="Mustafa"},
                new Customer{Id=5, SurName="gökhan" }
            });
            Console.WriteLine(customers.Contains(customer1));
            //customers.Clear();

            var index = customers.IndexOf(customer1);
            Console.WriteLine("Index:{0}", index);

            var index2 = customers.LastIndexOf(customer1);
            Console.WriteLine("İndex2={0}", index2);

            customers.Insert(0, customer1);
            customers.Remove(customer1);
            customers.RemoveAll(c => c.SurName == "Ali");
        
            foreach (var item in customers)
            {
                Console.WriteLine(item.SurName);
            }
            var count = customers.Count;
            Console.WriteLine("Count= {0}", count);
        }

        private static ArrayList ArrayList()
        {
            ArrayList citiesList = new ArrayList();
            citiesList.Add("Ankara");
            citiesList.Add("İstanbul");

            citiesList.Add("Adana");
            citiesList.Add(1);
            citiesList.Add('A');

            foreach (var item in citiesList)
            {
                Console.WriteLine(item);
            }

            return citiesList;
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string SurName { get; set; }
    }
}
