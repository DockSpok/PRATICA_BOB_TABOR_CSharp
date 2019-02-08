using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_bobTabor_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            OlaMundo();
            Console.ReadKey();
        }
        /* um método está dentro de uma classe
        e static void é um método. Então no nosso exemplo vem paralelo a ele....
        */
        private static void OlaMundo()
        {
            Console.WriteLine("Olá Mundo! Isso é um Método!");
        }
    }
}
