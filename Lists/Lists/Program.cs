using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var lista1 = new List<string>();
            lista1.Add("Chicago");
            lista1.Add("Nova Iorque");
            lista1.Add("Miami");
            lista1.Add("Nova Jersey");

            var lista2 = new List<string>();
            lista2.Add("Chicago");
            lista2.Add("Nova Iorque");
            lista2.Add("Nova Jersey");

            var resultado = lista1.Except(lista2);

            var outro = lista1.Where(x => !lista2.Any(z => z.FirstOrDefault() == x.FirstOrDefault())).ToList();

        }
    }
}
