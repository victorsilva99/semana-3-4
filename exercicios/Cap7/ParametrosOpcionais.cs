using System;
using static System.Console;

namespace livrocsharp
{
    class ParametrosOpcionais
    {
        //regra: obrigatorios DEVEM vir antes dos opicionais
        static decimal Faturamento(
            decimal qtde, decimal preco = 10, decimal bonus = 5)
            => qtde * preco + bonus;
            static void Main(string[] args)
            {
                WriteLine("Parametros Opicionais");
                WriteLine(Faturamento(500,5,10));
                WriteLine("Parâmetros 1 e 2");
                WriteLine(Faturamento(50,12));
                WriteLine("Parâmetros 1 e 3");
                WriteLine(Faturamento(50, bonus: 10));
                ReadLine();
            }
        
    }
}