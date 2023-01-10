using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);

            }

            List<Customer> result2=utilities.BuildList<Customer>(new Customer { FirstName="Engin"},new Customer { FirstName="Ali" });
            foreach (var item2 in result2)
            {
                Console.WriteLine(item2.FirstName);
            }
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    class Product:IEntity
    {

    }

    class Customer: IEntity
    {
        public string FirstName { get; set; }
    }

    interface IProductDal:IRepository<Product>
    {

    }
    class ProductDal : IProductDal
    {
        public void Add(Product t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product t)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product t)
        {
            throw new NotImplementedException();
        }
    }

    interface ICustomerDal:IRepository<Customer>
    {
        void Custom();
    }
    class CustomerDal : ICustomerDal
    {
        public void Add(Customer t)
        {
            throw new NotImplementedException();
        }

        public void Custom()
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer t)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer t)
        {
            throw new NotImplementedException();
        }
    }

    interface IEntity
    {

    }
    interface IRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T t);
        void Delete(T t);
        void Update(T t);
    }
}
