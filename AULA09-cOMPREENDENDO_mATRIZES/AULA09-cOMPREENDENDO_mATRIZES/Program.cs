using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA09_cOMPREENDENDO_mATRIZES
{
    class Program
    {
        static void Main(string[] args)
        {
            /* declarando uma Array e atribuindo imediatamente seus valores...
             int[] nomeDaMatriz = new int[] { 89, 90878987, 765765, 86567865, 3 , 12 };
             a matriz automaticamente assume a dimensão da quantidade de itens que encontra
             entre as chaves.
            */
            
            /*
            string [] irmaos = new string [] {"Roni", "Mauro", "Daniel", "Márcia", "Marina" };
            // a linha acima declara uma string do tipo Array e logo em seguida...
            // lhe atribui valores 'dontro das Chaves. O mesmo se aplica a números.
            foreach (string nome in irmaos)
            {
                Console.WriteLine(nome);
            }
            Console.ReadLine();
            */
            string citacaoDoZig = "Você pode conseguir o que você quer da vida " + 
                " se você ajudar muitas outras pessoas a conseguirem o que elas querem.";
            // declaro uma matriz 'array' do tipo char pra receber o resultado da transformação
            // que o método abaixo 'ToCharArray() vai produzir...
            char[] vouJogarAquiaCitacaoDoZig = citacaoDoZig.ToCharArray();
            // o método a seguir inverte a ordem da matriz
            Array.Reverse(vouJogarAquiaCitacaoDoZig);

            foreach (char variavelTemporariaSoPraEsseForEach in vouJogarAquiaCitacaoDoZig)
            {
                Console.Write(variavelTemporariaSoPraEsseForEach);
            }
            Console.ReadLine();
        }
    }
}
