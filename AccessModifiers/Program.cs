using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Customer
    {
        protected int Id;
        public void Save()
        {

        }
        public void Delete()
        {

        }
    }

    class Student:Customer
    {
        public void Save2()
        {
            
        }
    }

    public class Course
    {
        public string Name { get; set; }
    }
}
