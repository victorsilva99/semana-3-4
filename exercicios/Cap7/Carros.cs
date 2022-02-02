using System;
using System.Collections.Generic;

namespace livrocsharp
{
    public class Carro
    {
        public int ID {get; set;}
        public string Modelo {get; set;}
        public int Litros {get; set;}
        public double KmRodados {get; set;}
        public int AnoFabricacao {get; set;}
        public string Cor {get; set;}
        
        public double Consumo() => KmRodados / Litros;
        public string ConsumoString() => Litros > 0 ? $"{Consumo():n2}" : "----";
        public int idade() => DateTime.Today.Year - AnoFabricacao;
        public override string ToString() => $"{ID} - {Modelo}";

        public static List<Carro> Get()
        {
            return new List<Carro>
            {
                new Carro {ID = 1, Modelo = "Honda Civic", AnoFabricacao = 2000, KmRodados = 22000, Cor = Cores.Azul.ToString(), Litros=24},
            };
        }
    }
    enum Cores
    {
        Vermelho = 1,
        Verde = 2,
        Azul = 3
    }
}