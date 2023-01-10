using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //value types
            //Console.WriteLine("Hello World!");

            char character = 'A';
            double number5 = 10.5;// 64 bit
            int number1 = 10; //32 bit
            long number2 = 25689745; //64 bit
            short number3 = 32767; //16 bit
            byte number4 = 127; //8 bit
            bool condition = true;
            decimal number6 = 10.4M;

            Console.WriteLine("Character is :{0}",(int)character);
            Console.WriteLine(number5);
            Console.WriteLine(number4);
            Console.WriteLine(number3);
            Console.WriteLine(number2);
            Console.WriteLine("Number1: {0}",number1);

            //enum
            Console.WriteLine((int)Days.Friday);
        }
    }
    enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
