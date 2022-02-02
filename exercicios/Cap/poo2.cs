using static System.Console;
using System;

namespace MinhaClasseUsuario 
{
    class ProgramPrincipal
    {
        static void Main(string [] args)
        {
            //Criamos o objeto Pedido herdade da classe InteracaoUsuario
            InteracaoUsuario Pedido = new InteracaoUsuario();
            //Invocamos os metodos do objeto Pedido herdado da classe mãe InteracaoUsuario
            Pedido.SolicitarDigitacao();
            Pedido.MostrarDigitacao();

            //Recupero pelo método GET o valor da mensagem digitada para futura manipulação
            var Digitado = Pedido.Mensagem;
            //Escrevo a nova mensagem colocando toda a mensagem em Maiúscula
            WriteLine($"Nova Digitação sem Espaços -> {Digitado.ToUpper()}");
        }
        //Criamos a Classe IntercaoUsuario com dois metodos principais
        //Método que solicita a digitação de algo no terminal
        //Método que mostra o que retorna o que foi digitado
        class InteracaoUsuario
        {
            private string _MensagemDigitada;
            public string Mensagem
            {
                get
                {
                    return _MensagemDigitada;
                }
                set
                {
                    _MensagemDigitada = value;
                }
            }
            public void SolicitarDigitacao()
            {
                _MensagemDigitada = ReadLine();
            }
            public void MostrarDigitacao()
            {
                WriteLine(_MensagemDigitada);
            }
        }
    }
}