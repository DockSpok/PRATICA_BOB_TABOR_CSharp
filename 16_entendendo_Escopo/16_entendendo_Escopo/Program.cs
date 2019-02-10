using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_entendendo_Escopo
{
    class Program
    {
        private static string k = "";

        static void Main(string[] args)
        {
            string j = "";
            Console.WriteLine("Fora do escopo (E ANTES) do for: j = " + j);
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine("Valor do 'i' dentro do FOR: " + i);

                if (i == 9)
                {
                    string l = i.ToString();
                    Console.WriteLine("Dentro do escopo do for: l = i se i == 9 : l = " + j);
                }
                // Console.WriteLine(l);
            }
            // Console.WriteLine(i);
            Console.WriteLine("Fora do escopo (E DEPOIS) do for: j = " + j);
            Console.WriteLine("Fora do escopo (E DEPOIS) do for: k = " + k);

            // Notar o case sensitive.
            MetodoAuxiliar();

            Car meuCarro = new Car();
            Console.WriteLine("O objeto meuCarro está acessando 'FazAlgumaCoisa()' " +
                "que por sua vez chama 'metodoAuxiliar() e retorna o string 'Olá Mundo!'");
            meuCarro.FazAlgumaCoisa();

            // Espera.
            Console.ReadLine();
        }

        static void MetodoAuxiliar()
        {
            Console.WriteLine("Valor de K a partir do HelperMethod() é " + k + " porque foi declarada fora do FOR, onde é incrementada.");
        }

    }

    class Car
    {
        public void FazAlgumaCoisa()
        {

            Console.WriteLine(metodoAuxiliar());
        }

        private string metodoAuxiliar()
        {
            return "Olá Mundo!";
        }
    }
}
