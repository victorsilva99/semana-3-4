using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace livrocsharp
{
    class Dicionario
    {
        static void Main(string[] args)
        {
            WriteLine("--- uso de dicionaraios ---");
            var sexo = new Dictionary<string, string>();
            sexo.Add("M", "Masculino");
            sexo.Add("F", "Feminino");
            WriteLine(sexo["F"]);

            var cidades = new Dictionary<string, string>{
                ["MG"] = "Minas Gerais", //["Key"] = "Value"
                ["SC"] = "Santa Catarina",
                ["SP"] = "São Paulo",
                ["RS"] = "Rio Grande do Sul"
            };
            WriteLine ($"--- dicionário com {cidades.Count()} Cidades---");
            WriteLine(cidades["MG"]);
            //WriteLine(cidades["mg]); gera erro
            //WriteLine(cidades[0]); erro compilação
            foreach (var cidade in cidades)
            {
                WriteLine($"sigla: {cidade.Key} - {cidade.Value}");
            }
            WriteLine("--- dicionário Países ---");
            var paises = new Dictionary<int, string>
            {
                [100] = "Brasil",
                [2] = "Autralia",
                [60] = "Nova Zelandia"
            };
            foreach (var pais in paises)
            {
                WriteLine($"{pais.Key} - {pais.Value}");
            }
            var texto = new string []
            {
                        // índice do inicio     índice do final
                "Meu",         //0                  ^9
                "codigo",      //1                  ^8
                "rodou",       //2                  ^7
                "sem",         //3                  ^6
                "erros",       //4                  ^5
                "para",        //5                  ^4
                "ler",         //6                  ^3
                "cadastro",    //7                  ^2
                "clientes"     //8                  ^1
            };
            WriteLine("--- Índices do dicionário ---");
            WriteLine($"A última palavra é: {texto[^1]}");
            WriteLine($"A primeira palavra é: {texto[^9]}");

            WriteLine("--parte do texto ---");
            var pedacoTexto = texto[1..4];
            foreach (var p in pedacoTexto)
            {
                WriteLine(p);
            }
            
            WriteLine("---intervalo da coleção ---");
            Range intervalo = 1..6;
            foreach (var p in texto[intervalo])
            {
                WriteLine(p);
            }

            var todas = texto[..];  //todas as palavras
            WriteLine("---primeiras 4 ---");
            var Primerias4= texto[..4]; // primeiras 4 palavras
            foreach (var p in Primerias4)
            {
                WriteLine(p);
            }
            WriteLine("--- últimas 4 ---");
            var Ultimas4 = texto[5..]; //4 últimas pelo índice 5
            foreach (var p in Ultimas4)
            {
                WriteLine(p);
            }
            ReadLine();
        }
    }
}