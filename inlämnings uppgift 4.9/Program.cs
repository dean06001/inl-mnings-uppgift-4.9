using System;
namespace Uppgift_4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programmet ritar ut en rätvinklig triangel.");
            Console.WriteLine("Bestäm sidlängden på triangeln.");
            int längd = int.Parse(Console.ReadLine());

            for (int i = 0; i < längd; i++)
            {
                string triangle = new string('*', i + 1);
                Console.WriteLine(triangle);
            }
        }
    }
}
