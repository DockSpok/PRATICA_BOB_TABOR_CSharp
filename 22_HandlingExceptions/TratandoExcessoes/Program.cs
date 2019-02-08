using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratandoExcessoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string conteudo = File.ReadAllText(@"C:\vcobol2\Texto.txt");
                Console.WriteLine(conteudo);
            }
            catch (DirectoryNotFoundException esquisitice)
            {
                Console.WriteLine("Ooopa! Encontrei uma esquisitice...");
                Console.WriteLine(esquisitice.Message);
            }
            catch (FileNotFoundException esquisitice2)
            {
                Console.WriteLine("Uia! mais uma");
                Console.WriteLine(esquisitice2.Message);
            }
            finally
            {
                // mensagem final... se todas as falhas especificadas passaram, 
                // aqui daremos uma mensagem genérica.
                Console.WriteLine("Já era..");
            }
            Console.ReadKey();
        }
    }
}
