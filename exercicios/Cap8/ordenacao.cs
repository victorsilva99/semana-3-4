using System;
using static System.Console;
using System.Linq;

namespace livrocsharp
{
    public class ordencao
    {
        static void Main (string[] args)
        {
            var numeros = new [] {1,2,3,4,5,6,7,8,9,10};

            // --------- REVERSE --------------
            //Executa o operador de ordenação na coleção
            var numerosAoInverso = numeros.Reverse();
            
            //numeros normais
            foreach (var numero in numeros)
            {
                WriteLine(numero);
            }
            // Números inversos
            foreach (var numero in numerosAoInverso)
            {
                WriteLine(numero);
            }

            //--------- ORDERBY -------------------
            // Ordena de fomra ascendente (do menor para o maior)
            var numerosOrdenadosAscendente = numeros.OrderBy(n => n);

            //---------- ORDERBYDESCENDING -----------
            // Ordena de forma descendente (do maior para o menor)
            var numerosOrdenadosDescendente = numeros.OrderByDescending (n => n);

        }
    }
}