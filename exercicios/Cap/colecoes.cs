using static System.Console;
using System;
using System.Collections.Generic;

namespace livrocsharp
{
    class colecoes
    {
       public static void Main(string [] args)
       {
        //Declarando uma array com cem elementos do tipo inteiro
        WriteLine("----- Array");
        int[] primeiraArray = new int[100];

        //Declarando uma array e já atribuindo valores
        int[] segundaArray = {1,2,3,4,5,6};

        //Forma alteranativa de criar array
        int[] terceiraArray = {1,2,3,4,5,6};

        //Declarando uma array multi-dimensional
        int[,] arrayMultiDimensional = new int[2,3];

        //declarando uma array multi-dimensional e atribuindo valores
        int[,] arrayMultiDimensional2 = {{1,2,3},{4,5,6}};
       }
       public class ExemploClasseArray
       {
           static void ClasseArray()
           {
            //Observando o valor em um indice especifico.
            int[] segundArray = new int[] {1,3,5,7,9};
            WriteLine("Valor da array na posição 0 -> {0} ", segundArray[0]);
           }
       }
       public class ExemploList
       {
           static void Testa()
           {
               List<string> nomesFuncionarios = new List<string>();
               nomesFuncionarios.Add("Maria");
               nomesFuncionarios.Add("João");
               nomesFuncionarios.Add("André");
               nomesFuncionarios.Add("Flávia");
               WriteLine();
               foreach(string pessoa in nomesFuncionarios)
               {
                   WriteLine(pessoa);
               }
                WriteLine(nomesFuncionarios[0]);

                //Removendo Maria da lista
                nomesFuncionarios.RemoveAt(0);
                Console.WriteLine(nomesFuncionarios[0]);
           }
       }
       //Declarando uma classe genérica
       public class ListaGenerica<T>
       {
           public void Adicionar(T input) {}
       }
        class TestListaGenerica
        {
            private class ExampleClass {}
            static void Testa()
            {
                //Declarando uma lista do tipo inteiro
                ListaGenerica<int> lista1 = new ListaGenerica<int>();
                lista1.Adicionar(1);

                //Declarando uma lista do tipo string
                ListaGenerica<string> lista2 = new ListaGenerica<string>();
                lista2.Adicionar("");

                //Declarando uma lista do tipo de uma classe
                ListaGenerica<ExampleClass> lista3 = new ListaGenerica<ExampleClass>();
                lista3.Adicionar(new ExampleClass());
            }
       }
    }
}