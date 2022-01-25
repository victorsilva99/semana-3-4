using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tSystems.CursoCSharp.ConsoleAplication2; // informa que você deseja usar o outro projeto dentro da pasta; necessário ir em Solution > nome_do_projeto_atual (right clik) > Add > Reference.. > Selecionar nome_do_projeto_que_deseja_usar

namespace tSystems.CursoCSharp.ConsoleAplication
{
    class Program
    {
        #region Declaração de Enum
        enum DiasSemana                        // É utilizado para criar uma lista de constantes, com nomes ou valores pré definidos.
        {
            Domingo = 0,
            SegundaFeira = 1,
            TercaFeira = 2,
            QuartaFeira = 3,
            QuintaFeira = 4,
            SextaFeira = 5,
            Sabado = 6
        };
        #endregion

        static void Main(string[] args)
        {
            #region Criação de Váriavel, inserção de valores na variavel e imprimir na tela a variavel
            var nomeCorrentista = "";                               // Criação da variavel sem tipagem de dados;
            nomeCorrentista = Console.ReadLine();                   // Aguarda o usuário informar o que será alocado na váriavel;
            Console.Write("Nome da variável = " + nomeCorrentista);  // Printa na tela a mensagem; "+" irá concatenar com o valor da váriavel;
            Console.ReadLine();                                     // Irá aguardar a inserção de dados pelo usuário;
            #endregion

            #region Converter texto
            int xpto = Convert.ToInt32(Console.ReadLine());     // Por padrão, toda a inserção de dados no C# é interpretado como texto, por isso é necessário fazer a conversão para número se for trablhar com variaveis numericas
            /*ou*/
            int xpto2 = (int)DiasSemana.SegundaFeira;           // Pega o valor inteiro dentro do enumerado (lina 12).
            #endregion

            #region Converter um texto para data
            var dataAniversario = Convert.ToDateTime("07/02/1999");
            //ou
            DateTime dataAniversario2 = Convert.ToDateTime("07/02/1999");
            #endregion

            #region Operações Matemáticas
            double saldo = 100.0; // Double é um tipo de dado aconselhavel para trabalhar com valores monetários
            saldo = saldo - 10.0; // Aceita os operadores lógicos comuns (+ - * / % )
            #endregion

            #region Criação de Arrays
            String[] array = new String[2];     // "new" aloca o espaço na memória; Pode ser qualquer tipo de dados (int, double, etc); O indice começa no 0;
            array[0] = "Victor Silva";          // Como você definiu o indice e os valores eles serão imutáveis durante o processamento do seu software;
            array[1] = "Alessandra Ferreira";
            //ou
            String[] array2 = new string[2] { "Victor Silva", "Alessandra Ferreira" }; // Os dados serão armazenados no índice de maneira sequencial a qual foram informados
            Console.Write("O valor da posição 0 é: " + array2[0]);                  // irá printar na tela o valor da posição 0 (Victor Silva), serve para os dois modos

            #endregion

            #region Constantes
            const double Pi = 3.14159;              // "const" irá informar que é uma constante, ou seja, o valor dela não será alterado.
            double radius = 5.3;                    // Já esses são váriaveis, com isso o valor deles poderá ser alterado.
            double area = Pi * (radius * radius);

            #endregion

            #region Listas
            List<String> lista = new List<string>();                                           // Ao contrário dos Arrays, as listas são flexiveis, ou seja, você pode adicionar a quantidade de dados conforme a necessidae;
            lista.Add("Victor Silva");                                                         // ".Add" irá adicionar todos na lista os dados conforme o tipo especificado.
            lista.Add("Alessandra Ferreira");
            //ou
            List<String> lista2 = new List<string> { "Victor Silva", "Alessandra Ferreira" };
            //print
            Console.Write("Posicao inicial da lista: " + lista2[0]);                            // Para printar na tela segue a mesma sintaxe dos arrays, onde o valor informado nos colchetes [] é a posição do dado na lista
            Console.Write("Quantidade de nomes na lista: " + lista2.Count());                   // ".Count()" irá trazer a quantidade de items dentro dessa lista

            #endregion

            #region Enums
            // Os Enums precisam ser declarados fora do static void main (ver linha 12)
            var diaDaSemana = DiasSemana.SegundaFeira;      // Isso garante que os valores declarados serão exatamente os valores definidos no enumerado.
            int diaDaSemana2 = (int)DiasSemana.TercaFeira;  // Irá pegar o número intero declarado dentro do enumerador.
            Console.Write("Hoje é dia: " + diaDaSemana);    // Irá printar "SegundaFeira", pois foi declarado na váriavel conforme está no Enum.
            Console.Write("Valor do dia: " + diaDaSemana2); // Irá printar "2" pois é o valor inteiro declarado dentro do enum TercaFeira.

            #endregion

            #region IF / ELSE
            /* IF/ELSE representam uma estrutura de controle para que você verifique se a condição aprensentada é verdade ou falsa. Dessa forma,
             * você tomará decições durante o ciclo do seu software.*/

            double saldoConta = 100.0;
            Console.Write("Digite um valor para debitar da sua conta: ");
            var debitar = Convert.ToDouble(Console.ReadLine());

            saldoConta = saldoConta - debitar;

            if (saldoConta > 0)                                                                                             // Pode usar os operadores (< > == != <= >= &&
            {
                Console.Write("Seu saldo é positivo. Você debitou {0}. Ainda restam {1} em conta", debitar, saldoConta);   // "{0} irá reservar o local na mensagem para colocar a variavel informada, o número representa a posição da variavel informada começando por 0
            }
            else
            {
                Console.Write("Seu saldo é negativo!");
            }

            #endregion

            #region FOR
            int tamanho = 10;

            for (int i = 0; i < tamanho; i++)                           // digite "for" e aperte tab 2x para o codígo ser escrito automático.
            {
                Console.Write("O valor da variável i é" + i + "\n");    // "\n" irá quebrar a linha.
            }
            #endregion

            #region FOREACH
            /* Foreach representa um loop onde você roda um bloco repetidamente analisando o valor de cada elemento de forma individual.*/

            List<string> nomes = new List<string> { "Victor Silva", "Alessandra Ferreira" }; // Essa lista seria uma "coleção" de nomes

            foreach (var item in nomes)
            {
                Console.Write("O nome da pessoa é: " + item);
            }
            #endregion

            #region SWITCH
            /* Switch é uma declaração de seleção onde você executa apenas uma condição verdadeira dentro de uma lista de possíveis candidatos.*/

            double saldoConta2 = 100.0;
            Console.Write("Digite um valor para debitar da sua conta: ");
            var debitar2 = Convert.ToDouble(Console.ReadLine());

            saldoConta2 = saldoConta2 - debitar2;

            switch (saldoConta2)
            {
                case 50.0:
                    Console.Write("Você debitou 50 da sua conta");
                    break;
                case 10.0:
                    Console.Write("Você debitou 90 da sua conta");
                    break;
                default:
                    Console.Write("Você debitou [0] da sua conta", debitar2);
                    break;
            }
            #endregion

            #region Classes e Objetos
            /* Uma classe permite que você crie seus próprios tipos personalizados através do agrupamento de variáveis e outros tipo, métodos e eventos.
            * Entenda classe como uma representação dos modelos da vida real disposta como um entidade no seu software.
            *  Para criar uma nova classe acesse: Soluction Explorer > SeuProjeto (botão direito) > Add > Class..
            *
            * Objeto é uma representação da sua classe na memória do seu computador;
            */
            Pessoa Aluno = new Pessoa();                 // Aqui eu estou chamando a classe Pessoa e criando um objeto chamado Aluno, é muito semelhante a tipagem de dados, essa classe que criamos seria como um novo tipo de dado, porém com as nossas informações que declaramos  na classe.
            Aluno.CPF = "12345678985";                   // o "." irá chamar (get) todas as propriedades que colocamos na classe Pessoa, e assim eu posso manipular os dados dentro dela (set).
            /*ou*/
            Pessoa Aluno2 = new Pessoa()
            {
                CPF = "1234567885"
            };

            //Exemplo de uso da classe/objeto

            List<Pessoa> ListaDePessoas = new List<Pessoa>();
            ListaDePessoas.Add(Aluno);

            foreach (var pessoa in ListaDePessoas)
            {
                Console.Write("CPF do Aluno: " + pessoa.CPF);
            }

            // Exemplo de Método
            Pessoa funcionario = new Pessoa();
            funcionario.EfetuarDeposito(50.0);                                              // dentro do parentese está o parametro "valorDeposito" informado no método;
            Console.Write("O saldo da conta é de: " + funcionario.EfetuarDeposito(50.0));   // aqui já estamos realizando o médoto dentro da mensagem para assim já ser exibido o "return"

            // Podemos fazer algo dinamico, deixando que o usuario informe o valor do parametro
            Pessoa usuario = new Pessoa();                                                  // Aqui chamo a classe e instancio o objeto usuario, para que seja possivel usar os metodos.
            Console.Write("Informe o valor do deposito: ");                                 // Pede ao usuario o valor do deposito
            double valorDeposito = Convert.ToDouble(Console.ReadLine());                    // Aqui ele lê o que o usuario digitou, converte para double e armazena dentro da variavel "valorDeposito"
            Console.Write("Seu saldo agora é: " + usuario.EfetuarDeposito(valorDeposito)); // E por fim, concateno dentro da mensagem o resultado do medoto "EfetuarDeposito" usando a variavel "valorDeposito" como parametro

            #endregion

        }
    }
}
