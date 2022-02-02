using System;
using static System.Console;
using System.Linq;

namespace livrocsharp
{
    class juncao
    {
        static void Main(string[] args)
        {
        
        var colecao1 = new [] {1,2,3};
        var colecao2 = new [] {4,5,6};

        //------ CONCAT--------
        //Executa o operador para juntar duas ou mais coleções
        var numerosConcatenados = colecao1.Concat(colecao2);
        }
        
    }
}