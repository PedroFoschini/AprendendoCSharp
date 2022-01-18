using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p13_ForEncadeado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 13 - Laços encadeados");

            // Usando break
            for(int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for(int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if(contadorColuna >= contadorLinha)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }


            // Forma alternativa
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Fim da execução. Pressione Enter para sair...");
            Console.ReadLine();
        }
    }
}
