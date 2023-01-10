using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();

            var result = Add2(20, 30);
            Console.WriteLine(result);

            var result2 = Add3(18);
            Console.WriteLine(result2);

            //ref keyword
            //int number1 = 20;
            //int number2 = 100;
            //var result3 = Add4(ref number1, number2);
            //Console.WriteLine(result3);
            //Console.WriteLine(number1);


            //out keyword
            //int sayi1 = 20;
            //int sayi2 = 100;
            //var result4 = Add5(out sayi1, sayi2);
            //Console.WriteLine(result4);
            //Console.WriteLine(sayi1);

            //Method Overloading
            Console.WriteLine(Multiply(3,5,4));

            //Chanllenge Params Keyword
            Console.WriteLine(Add6(6,3,5,7));
        }

        static void Add()
        {
            Console.WriteLine("Added!!!!");
        }

        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(int number1, int number2=15)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add4(ref int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Add5(out int sayi1, int sayi2)
        {
            sayi1 = 30;
            return sayi1 + sayi2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2*number3;
        }

        static int Add6(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
