using System;
using System.Threading;

namespace Funcs
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = Topla;

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            Console.WriteLine(getRandomNumber());

            Thread.Sleep(1000);
            Func<int> getRandomNumber2=()=> new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber2());

            //Console.WriteLine(add(4,5));

            Console.WriteLine(Topla(2,3));
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }
    }

    
}
