using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula Poupança");

            double valorInvestido = 1000.0;

            int contadorMes = 1;
            while (contadorMes <= 12){

                // 0.36% = 0.0036
                valorInvestido += valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + "meses, você terá R$" + valorInvestido);
                contadorMes++;
            }


            Console.WriteLine("Fim da execução. Pressione Enter para sair...");
            Console.ReadLine();
        }
    }
}
