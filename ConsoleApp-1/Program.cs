using System;
using System.Collections.Generic;

namespace ConsoleApp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<int>();
            
            lista.Add(int.Parse(Console.ReadLine()));
            lista.Add(int.Parse(Console.ReadLine()));

            if (lista[0] > lista[1])
            {
                Console.WriteLine("Liczba 1 jest większa od liczby 2.");
            }

            if (lista[0] < lista[1])
            {
                Console.WriteLine("Liczba 1 jest mniejsza od liczby 2.");
            }

            if (lista[0] == lista[1])
            {
                Console.WriteLine("Liczba 1 jest równa liczbie 2.");
            }
        }
    }
}
