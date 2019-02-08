using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula08_For_iteration
{
    class Program
    {
        static void Main(string[] args)
        {
           // esse 'for' foi inserido apenas escrevendo for e TAB + TAB.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter para continuar..." + i);
                Console.ReadLine();
                if ( i == 7 )
                {
                    Console.WriteLine("Achei o sete!");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
