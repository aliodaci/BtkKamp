﻿using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = { new Manager(), new Worker(), new Robot()};

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = { new Manager(), new Worker() };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
