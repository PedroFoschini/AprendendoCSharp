using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais parte 2");

            int idadeJoao = 16;
            int quantidadePessoas = 2;
            bool estaAcompanhado = quantidadePessoas >= 2;

            if (idadeJoao >= 18 || estaAcompanhado == true)
            {
                Console.WriteLine("Pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }

            Console.WriteLine("Fim da execução. Pressione Enter para sair...");
            Console.ReadLine();

        }
    }
}
