using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ClassesSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            // após haver criado a classe com algumas propriedades, vou instanciar um objeto
            // aqui, a partir desta classe, usando NEW
            Carro yelowSubmarino = new Carro();
            yelowSubmarino.Ano = 1978;
            yelowSubmarino.Cor = "Amarelo";
            yelowSubmarino.Fabricante = "Chrysler";
            yelowSubmarino.Modelo = "Dodge Dart";
            // agora vamos imprimir pra ver como ficou...
            Console.WriteLine("{1} {0} {2} {3}", // aproveitando pra testar a ordenação
                yelowSubmarino.Modelo,
                yelowSubmarino.Fabricante,
                yelowSubmarino.Ano,
                yelowSubmarino.Cor);
            // depois de ter criado o método que determina o valor do carro de dentro da classe...
            // vamos chamar esse método aqui do programa para imprimir esse valor.
            Console.WriteLine("{0:C}", yelowSubmarino.DeterminaValorDeMercado());

            Console.ReadKey();
        }
    }
    // criando uma classe 'Carros' FORA da class program e no mesmo nível e não do namespace
    class Carro
    {
        // convém primeiro criar as propriedades (usando o atalho PROP+TAB+TAB...
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        // em seguida criamos os métodos. Nesse exemplo, apenas um para definir preço conforme ano. 
        public decimal DeterminaValorDeMercado()
        {
            decimal Valor;
            if (Ano > 2000)
                Valor = 10000;
            else
                Valor = 5000;
            return Valor;
        }
    }
}
