using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaGenerica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista generica");

            List<Object> lista = new List<Object>();
            lista.Add(1);
            lista.Add(2);
            lista.Add(-3);
            lista.Add(2.9);
            lista.Add("omy");
            lista.Add(false);

            Console.WriteLine("visualizzazione dati lista");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nnuemeri di elementi in una lista: {lista.Count}");

            Console.WriteLine($"\nelenco dati peresenti nella lista di ditop stringa");
            foreach (var item in lista)
            {
                if (item is string)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}