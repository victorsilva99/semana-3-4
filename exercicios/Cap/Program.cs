using System;
using MinhaClasseUsuario;
using static System.Console;

namespace MinhaPrimeiraClasse{
    class ProgramPrincipal{
        static void Main(String [] args){
            //Criamos o objeto Pedido Herdado da classe InteracaoUsuario
            InteracaoUsuario Pedido = new InteracaoUsuario();
            //Invocamos os metodos do objeto Pedido Herdado da classe mãe InteracaoUsuario
            Pedido.SolicitarDigitacao();
            Pedido.MostrarDigitacao();

            //Recuperamos pelo método GET o valor da mesagem digita para futura manipulação
            var Digitado = Pedido.Mensagem;
            //Escrevemos a nova mensagem colocando toda a mensagem em Maiúscula
            WriteLine($"Nova Digitação sem espaços -> {Digitado.ToUpper()}");
        }
    }
}