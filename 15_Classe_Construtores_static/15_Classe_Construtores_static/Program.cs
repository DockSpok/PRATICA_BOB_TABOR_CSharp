using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Classe_Construtores_static
{
    class Program
    {
        static void Main(string[] args)
        {
            // criado o primeiro objeto da classe
            Livro livro01 = new Livro();
            livro01.Autor = "Barthes";
            livro01.Titulo = "Mitologias";
            // criado o segundoobjeto da classe
            Livro livro02 = new Livro();
            livro02.Autor = "Chrishna";
            livro02.Titulo = "Gita";

            Console.WriteLine("{0} - {1} - {2}", livro01.Titulo, livro01.Autor, livro01.Editora);

            Console.ReadKey();
        }
    }
    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }

        /* agora vou criar um constructor (que é um método...) 
        // serve para facilitar o uso desta classe, sua inicialização como objeto
        // como por exeplo, se estou puxando os valores do objeto 
        de um banco de dados ou de uma folha de dados.
        */
        public Livro()
        {
            this.Editora = "Pensamento";
            //o 'this' aqui é opcional, serve apenas apra informar o escopo.
        }
    }
}
