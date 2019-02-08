using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisoes
    // referente à aula 06 do curso do Bob Tabor MS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("A Grande Premiação do Maorok");
            Console.WriteLine("Escolha uma Porta: 1, 2 ou 3: ");
            string usuarioDigita = Console.ReadLine();
            string mensagem = "";  // declarar fora do escopo dos blocos de IF abaixo

            if (usuarioDigita == "1")
            //  == é sinal para booleano e aceita só False ou True como resposta.
            {
                mensagem = "Você ganhou um carro novo!";
                // se eu tenho apenas um comando dentro da condição, 
                // posso não usar as chaves, como exemplificado abaixo.
            }
            else if (usuarioDigita == "2")
                mensagem = "Você ganhou um novo barco!";
            else if (usuarioDigita == "3")
                mensagem = "Você ganhou um milhão de dólares!";
            else  // também conhecida como condição "pega tudo" "catch all"
            {
                mensagem = "Não entendi sua resposta...";
                // mensagem = mensagem + " você perdeu.";
                // o C# tem um operadar para incremento que evita 
                // escrever de novo a variável (é o  atribuir e concatenar += )
                mensagem += "Você perdeu.";
            }
            Console.WriteLine(mensagem);
            Console.ReadLine();
            */

            Console.WriteLine("A Grande Premiação do Maorok");
            Console.WriteLine("Escolha uma Porta: 1, 2 ou 3: ");
            string usuarioDigita = Console.ReadLine();

            string mensagem = (usuarioDigita == "1") ? "barco" : "prendedor de roupas";
            // a linha acima é uma condicional... 
            // assim... variavel1 = (variavel2 == "verificar") ? "se true" : "se False";
            // declara-se uma variável com o valor entre parenteses + ?
            // o que está entre () é a condição F ou V...
            // o que está antes dos ":" é a resposta para o verdadeiro... 
            // e depois a resposta para o o Falso
            // a resposta, valor, será atribuída à variável 1
            /*
            Console.Write("Você ganhou um ");
            Console.Write(mensagem);
            Console.WriteLine(".");
            */
            Console.WriteLine("Você digitou {0}, portanto, ganhou um {1}!", usuarioDigita, mensagem);
            // este é um recurso de substituição 'iniciando sempre do zero', atribuirá os
            // valores das variáveis listadas na sequencia logo à frente 'separadas por vírgulas 
            // na ordem em que aparecem. Ou seja, se definir a substituição para 
            // Console.WriteLine("texto {3} e mais texto {0} e tal {2} e coisa {1}, etc.", A, B, C, D);
            // será impresso... texto D e mais texto A e tal C e coisa B, etc.
            Console.ReadLine();
        }
    }
}
