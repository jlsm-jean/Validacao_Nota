using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, media;
            n1 = float.Parse(Console.ReadLine());
            while (n1 < 0F || n1 > 10F)
            {
                Console.WriteLine("nota invalida");
                n1 = float.Parse(Console.ReadLine());
            }
            n2 = float.Parse(Console.ReadLine());
            while (n2 < 0F || n2 > 10F)
            {
                Console.WriteLine("nota invalida");
                n2 = float.Parse(Console.ReadLine());
            }

            media = (n1 + n2) / 2;
            Console.WriteLine("media = " + media.ToString("N2"));

        }
    }
}