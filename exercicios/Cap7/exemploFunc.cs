using System;
using System.Linq;
using static System.Console;

namespace livrocsharp
{
    class ExemploFunc
    {
        private const char Separator = '';

        static void Main(string[] args)
        {
            //Func< até 16 entrar e UMA sáida>
            int contador = 0;
            Func<int> numero = () => ++contador;
            WriteLine($"chamada 1 {numero()}");
            WriteLine($"chamada 2 {numero()}");
            WriteLine($"contador: {contador}");

            //Quantos caracteres contém o texto "Visual C#"?
            Func<string, int> MetodoQtdeCaracteres = (t) => t.Length;
            WriteLine(MetodoQtdeCaracteres("Visual C#"));

            //Qtas palavras contém um expressão?
            WriteLine("----- qtde palavaras");
            Func<string, int> MetodoQtdePalavras = (t) => 
            t.Split(' ')
            .Where(x => x != "")
            .Count();
            WriteLine(MetodoQtdePalavras("   Brasil     campeão    mundial de  volei   "));

            //calcular o imposto
            // salario, perc, aliquota
            // formula salario * (pperc / 100) - aliquota
            // condicao: salario <= 1000 >>> imposto = 0
            // cond ? true : false
            Func<decimal, decimal, decimal, decimal>
            imposto = (salario, perc, aliquota) =>
            {
                return salario <= 1000 ? 0 :
                salario * (perc / 100) - aliquota;
            };
            WriteLine("---- calculo do imposto ---");
            WriteLine(imposto(1000, 10, 10));
            WriteLine(imposto(5000, 27.5M, 10));
            WriteLine(imposto(23500, 32.5M, 180));

            WriteLine("----- cálculo de FUNC em coleções");
            // Formula: média de km rodados por ano
            // km / (today.year - ano)
            //"Modelo - ano - Km - Cor - Litros - km/ano"
            int anoAtual = DateTime.Today.Year;
            Func<int, double, double> CalculoKmPorAno = (ano, km) => ano >= anoAtual ? km : km / (anoAtual - ano);

            // Carrega a lista de carros
            var dados = Carro.Get();

            // looping para varrer todos os carros da lista
            dados.ForEach (x =>
            {
                var kmPorAno = CalculoKmPorAno(
                    x.AnoFabricacao, x.KmRodados);
                    WriteLine($"{x.Modelo} | ano: {x.AnoFabricacao} | km: {x.KmRodados:n0} | litros {x.Litros} | km/ano: {kmPorAno:n0}");
            });
            ReadLine();
        }
    }
}