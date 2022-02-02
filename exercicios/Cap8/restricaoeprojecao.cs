using System;
using static System.Console;
using System.Linq;

namespace livrocsharp
{
    class restricao
    {
        static void Main(string[] args)
        {
            // coleção de pessoas
            var pessoas = new []
            {
                "Carlos dos Santos",
                "Renato Haddad",
                "Claudenir Andrade",
                "Andre Carlucci",
                "Ray Carneiro",
                "Rafael Almeida",
            };

            // Filtro de pessoas que contém nome Almeida
            var pessoasFiltradas = pessoas.Where(p=>p.Contains("Almeida"));

            //Iteração com pessoas filtradas
            foreach(var pessoa in pessoasFiltradas)
            {
                //imprime no console o nome da pessoa
                WriteLine(pessoa);
            }
        }
    }
    class projecao
    {
        static void Main(string[] args)
        {
            var numeros = new [] {1, 2, 3};

            //----------- SELECT -----------
            // Fornece capacidade de transformar objetos de sua coleção em um nova coleção de objetos formatados, enriquecidos, filtrados.
            var categorias = numeros.Select(p => new
            {
                Id = p, // p = número da coleção
                Descricao = $"Categoria {p}"
            });
            
            foreach (var c in categorias)
            {
                var descricao = $"Categorias: {c.Id} - {c.Descricao}";
                WriteLine(descricao);
            }
        }
    }
}