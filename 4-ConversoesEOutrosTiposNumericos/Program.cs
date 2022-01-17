using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            int salarioEmInteiro = (int)salario;

            Console.WriteLine("O salário em inteiro é: " + salarioEmInteiro);

            // O long é uma variável de 64 bits
            long idade = 13000000000;

            // O short é uma variável de 16 bits
            short quantidadeProdutos = 16000;

            Console.WriteLine("A variável idade é: " + idade +
                ". Enquanto a variável quantidadeProdutos é: " + quantidadeProdutos);

            // Necessário utilizar o sufixo f
            float altura = 1.80f;
            Console.WriteLine("Altura: " + altura);


            Console.WriteLine("Fim da execução. Aperte Enter para sair...");
            Console.ReadLine();
        }
    }
}
