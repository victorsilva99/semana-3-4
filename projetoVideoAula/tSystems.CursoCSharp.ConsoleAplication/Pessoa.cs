using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tSystems.CursoCSharp.ConsoleAplication
{
    class Pessoa
    {
        /*----Propriedades----*/
        //"public" é um modificador de acesso, nesse caso (public) significa que ele é púlico, ou seja, qualquer pessoa pode acessar ou mudar os dados dentro dela.
        // "get" é usado para pegar informações dentro do modificador; "set" é usado para alterar informações dentro do modificador;
        public string CPF { get; set; }

        /*----- Métodos (ações) ------*/
        // "void" significa que o método não irá retornar nenhuma informação.
        public double EfetuarDeposito(double ValorDeposito) // "public double" informa que o método é publico e irá retornar um tipo "double"; Depois vem o nome do método e em parenteses os parametros; 
        {
            double saldo = 100.0;
            return saldo = saldo + ValorDeposito;           // por ser diferente de "void", o método ira exigir um retorno de algum dado, nesse caso usamos o "return"
        }
    }
}
