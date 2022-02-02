using static System.Console;
using System;

namespace livrocsharp
{
    class ProgramaPrincipal
    {
        static void Main(string []args)
        {
            //Criamos o objeto Pedido herdado da classe InteraçãoUsuario
            InteracaoUsuario Pedido = new InteracaoUsuario();
            //Invocamos os medodos do objeto Pedido herdado da classe mãe InteracaoUsuario
            var Digitado = Pedido.SolicitarDigitacao();
            Pedido.MostrarDigitacao(Digitado);
        }
        //Criamos a Classe InteracaoUsuario com dois metodos principais
        //Método que solicita a digitação de algo no terminals
        //Método que mostra o que foi digitado
        class InteracaoUsuario 
        {
            public string SolicitarDigitacao()
            {
                return ReadLine();
            }    
            public void MostrarDigitacao(string Digitado)            
            {
                WriteLine(Digitado);
            }
        }
    }
}