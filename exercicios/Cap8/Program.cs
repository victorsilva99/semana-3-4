using System;
using static System.Console;
using System.Linq;

namespace livrocsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array de números
            var numeros = new [] {1,2,3,4,5,6,7,8,9,10};

            //filtrar números
            var numerosFiltrados = numeros.Where(n=> n > 5);
            //ou
            var numerosFiltrados2 = from n in numeros where n > 5 select n;

            //Fazer iteração 1
            foreach (var numero in numerosFiltrados)
            {
                WriteLine(numero);
            }
            foreach (var numero in numerosFiltrados2)
            {
                WriteLine(numero);
            }
        }
    }
}
