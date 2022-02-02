using System;
using static System.Console;
using static System.Math;
using static System.String;

namespace livrocsharp
{
    class usingStatic
    {
        static void Main(string[] args)
        {
            //System.Math
            //raiz Quadrada
            WriteLine($"Raiz quadrada: {Sqrt(3*3 + 4*4)}");

            // Retorna o valor absoluto
            WriteLine($"Valor absoluto positivo: {Abs(1234.78)}");
            WriteLine($"Valor absoluto negativo: {Abs(-1234.78)}");
            WriteLine($"Valor absoluto negativo: {Abs(-850.99M)}");

            WriteLine($"Valor Máximo: {Max(100, 590)}");
            WriteLine($"Valor Minimo: {Min(100,590)}");

            //Arredonda um valor para o inteiro mais próximo ou para o número especificado decadas decimais.

            WriteLine($"Arredodna com 1 casa decimal: {Round(3250.895M, 1)}");
            WriteLine($"Arredonda com 2 casas decimais: {Round(3250.899M, 2)}");

            //System.String
            WriteLine($"Tamanho da String: {"Livro de C#".Length}");
            WriteLine($"Concatena 2 strings: {Concat("Livro de C#","Livro de EF Core")}");
            string livro = "Livro de EF Core";
            WriteLine($"{livro.Insert(6, "avançado").ToUpper()}");
            


        }
    }
}
