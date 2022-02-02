using System;
using static System.Console;
using System.Linq;

namespace livrocsharp
{
    class paginacao
    {
        static void Main(string[] args)
        {
            var numeros = new [] {5,4,9,6,7,2};

            //----------- TAKE ----------------
            // Executa o operador de paginação Take na seleção
            var doisElementos = numeros.Take(2); // irá pegar os 2 primeiros elementos

            // --------- TAKEWHILE--------------
            /*Ele percorrerá toda a váriavel e armazenará as condições enquanto a expressão for *TRUE, quando a expressão for FALSE ele irá parar a execução e retornará apenas os *eleementos anteriores ao FALSE*/
            var items = numeros.TakeWhile(n => n < 6);
            // RESULTADO:
            // 5
            // 4
            // Apesar de 2 ser <6 ele não aparece no resultado pois está logo após a 9, como 9>6 a expressão deu FALSE e a execução do comando foi paralizada naquele ponto.

            //------------ FIRST ----------------
            // retorna o primeiro elemento da coleção
            var primeiroElemento = numeros.First();

            // sobrecarga na qual assim que o primeiro elemento da lista atender ao critério ele imediatamente será selecionado.
            var primeiroElementoCriterio =  numeros.First(n => n == 9);
            //RESULTADO
            // 9
            // 5 era o primeiro elemento da condição, mas não atende o critério.
            // critérios que não forem atingidos irão gerar um erro "InvalidOperationException"

            //-----------FIRSORDEFAULT----------------
            // Tem o mesmo comprotamento do FIRST, porém, quando o critério não é atendio não gerará um erro, retorná o valor padrão com base no tipo.
            var numero = numeros.FirstOrDefault(p => p == 10);
            //Como não tem o número 10 na coleção irá retornar um valor padrão de Int, que é 0.

            //--------- LAST E LASTDEFAULT ---------
            // Tem o mesmo coportamento do FIRST e FRISTORDEFAULT, o que muda é apenas o retorno do elemento, retornando o último elemento da coleção
            var numeroLast = numeros.Last (); // resultado: 2
            var numeroLastDefault = numeros.LastOrDefault (p => p ==10); // resultado: 0

            // ---------- SKIP -------------------
            //Pula elementos da coleção até chegar na posição desejada
            var numerosPaginados = numeros.Skip(3);// Resultado: 6,7,2
            // Ele pulou 3 elementos da coleção, e começou do 4° em diante

            // ----------- ELEMENTAT ----------------
            // Chama o elemento com base no idice informado
            var elementat = numeros.ElementAt(1); //Resultado: 4
            // como o indice começa com 0, foi retornado o numero 4 e não o primeiro número, 5.

            // ------------- SINGLE E SINGLEORDEFAULT -----------
            // Encontra dentro da coleção algum elemento que seja único, e em caso de repetição retorna um erro
            var single = numeros.Single(p => p == 3);

            
        }
    }
}