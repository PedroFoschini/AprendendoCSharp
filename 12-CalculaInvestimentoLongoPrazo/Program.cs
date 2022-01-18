using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_CalculaInvestimentoLongoPrazo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 12 - Calcula Investimento Longo Prazo");

            double valorInvestido = 1000.0;
            double fatorRentimento = 1.0036;

            for(int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRentimento;
                }
                fatorRentimento += 0.0010;
            }

            Console.WriteLine("Ao final do período, você terá R$" + valorInvestido);



            Console.WriteLine("Fim da execução. Pressione Enter para sair...");
            Console.ReadLine();
        }
    }
}
