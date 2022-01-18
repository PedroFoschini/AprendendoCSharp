using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11_CalculaPoupanca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11 - Calcula Poupança 2");

            double valorInvestido = 1000.0;

            for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + contadorMes + "meses, você terá R$" + valorInvestido);
            }


            Console.WriteLine("Fim da execução. Pressione Enter para sair...");
            Console.ReadLine();
        }
    }
}
