using System;
using static System.Console;
using System.Linq;

namespace livrocsharp
{
    class agregacao
    {
        static void Main(string[] args)
        {
            var numeros = new [] {1,2,3,4,5,6,7,8,9,10};

            //--------- COUNT -------------
            // Faz contagem em toda coleção
            var countTotal = numeros.Count();

            //faz contagem na coleção com filtro
            var contParcial = numeros.Count (n => n >5);

            //---------- SUM ---------------
            // Soma todos os elementos da coleção
            var somaTotal = numeros.Sum();

            // Soma o elemento da coleção multiplicado por 2
            var somaComMultiplicação = numeros.Sum(n => n*2);

            //----------- MAX ---------------
            // Recupera o valor máximo de um elemtno da coleção
            var maxTotal = numeros.Max();

            // ----------- MIN --------------
            // Recupera o valor minimo de um elemento da coleção
            var minTotal = numeros.Min();

            //------------ AVERAGE ------------
            // Média dos elementos da coleção
            var media = numeros.Average();
        }
    }
}