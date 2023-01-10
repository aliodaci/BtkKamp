using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intro();

            string sentence = "My name is Engin Demiroğ";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name Derin Demiroğ";

            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(5, 9);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ", "-");
            var result13 = sentence.Remove(2);
            Console.WriteLine(result9);

        }

        private static void Intro()
        {
            string city = "Mersin";
            Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            Console.WriteLine(String.Format("{0}, {1}", city, city2));
        }
    }
}
