using System;
using static System.Console;

namespace LibaryClass{//namespace que irá conter a classe de controle de livros e seus metodos
    //nova classe para controlar as revistas
    public class Revistas : Biblioteca{
        //Propripriedade da classe
        private int _MesPublicacao;
        private int _AnoPublicacao;
        //Construtor da classe
        public Revistas(int MesPublicacao, int AnoPublicacao){
            _MesPublicacao = MesPublicacao;
            _AnoPublicacao = AnoPublicacao;
        }
        public int MesPublicacao // Metodo para aceso a propriedades da classe
        {
            get {return _MesPublicacao;} set {_MesPublicacao = value;}
        }
        public int AnoPublicacao
        {
            get {return _AnoPublicacao;} set{_AnoPublicacao = value;}
        }
    }
    public class Biblioteca{//principal classe de controle de livros na biblioteca
        private string _Titulo; // recebe o titulo do livro
        private string _Autor;//recebe o nome do autor do livro
        private int _Paginas; // recebe o número de pag. que o livro contém
        private bool _Status; // recebe saindo (FALSE) ou entrando (TRUE) na biblioteca

        public Biblioteca(){ //Construtor sem parametros
        }
        //construtor com parametros
        public Biblioteca(string Titulo, string Autor, int Paginas, bool Status){
            _Titulo = Titulo;
            _Autor = Autor;
            _Paginas = Paginas;
            _Status = Status;
        }
        public string Titulo //Metodo para acesso a propriedade Titulo da classe
        {
            get {return _Titulo;} set{_Titulo = value;}
        }
        public string Autor
        {
            get {return _Autor;} set{_Autor = value;}
        }
        public int Paginas
        {
            get {return _Paginas;} set {_Paginas = value;}
        }
        public bool Status
        {
            get {return _Status;} set {_Status = value;}
        }
    }
}