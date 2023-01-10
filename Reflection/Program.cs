﻿using System;
using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(4, 3));

            var type = typeof(DortIslem);

            //DortIslem dortIslem=(DortIslem)Activator.CreateInstance(type,6,7);
            //Console.WriteLine(dortIslem.Topla(4,5));
            //Console.WriteLine(dortIslem.Topla2());

            var instance = Activator.CreateInstance(type, 6, 5);

            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance, null));
            //Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null));

            Console.WriteLine("----------------------------");
            var metodlar = type.GetMethods();
            foreach (var item in metodlar)
            {
                Console.WriteLine("Method: {0}",item.Name);
                foreach (var parameterInfo in item.GetParameters())
                {
                    Console.WriteLine("Parametreler: {0}",parameterInfo.Name);
                }

                foreach (var attribute in item.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute: {0}",attribute.GetType().Name);
                }
            }

        }
    }

    class DortIslem
    {
        private int _sayi1;
        private int _sayi2;
        public DortIslem(int sayi1,int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1+ _sayi2;
        }
        [MethodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }

    }

    class MethodNameAttribute:Attribute
    {
        public MethodNameAttribute(string name)
        {

        }
    }
}
