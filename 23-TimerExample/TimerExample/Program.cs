using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer meuRelogio = new Timer(2000);

            // esse 'meuRelogio' é um 'event handler', instancia da classe Timer
            // criada aqui para guardar os métodos, as instrucoes que serao executadas
            // cada vez que o 'evento' que nesse caso é um Timer(2000) ocorrer.
            meuRelogio.Elapsed += MeuRelogio_Elapsed1; 
            // sendo que este segundo 'event handler' vai 
            meuRelogio.Elapsed += MeuRelogio_Elapsed2;
            // agora eu vou criar um método desses usando o construtor só pra treinar...
            meuRelogio.Elapsed += MeuRelogio_Elapsed3;

            meuRelogio.Start();

            Console.WriteLine("Tecle enter e eu paro de imprimir o evento vermelho.");
            Console.ReadLine();

            // a seguir, o '-=' retira o método criado, MyTimer_Elapsed1, do 
            // 'segurador de eventos' meuRelogio, então ele para de ser chamado
            // a cada vez que o evento Timer(2000) ocorre "is rased"
            meuRelogio.Elapsed -= MeuRelogio_Elapsed2;

            Console.ReadLine();
        }
        // cada método desses é criado automaticamente pelo construtor com o TAB
        //
        private static void MeuRelogio_Elapsed3(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Em milisegundos... {0:HH:mm:ss.ffff}", e.SignalTime);
        }

        // esse é um segundo 'evento' propriamente dito.
        private static void MeuRelogio_Elapsed2(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed1: {0:HH:mm:ss.fff}", e.SignalTime);
        }
        // esse é um 'evento' propriamente dito.
        private static void MeuRelogio_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}
