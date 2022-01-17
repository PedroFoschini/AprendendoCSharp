﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeJoao = 16;            
            bool estaAcompanhado = false;
            string mensagemAdicional;

            if(estaAcompanhado == true)
            {
                mensagemAdicional = "João está acompanhado";
            }
            else
            {
                mensagemAdicional = "João não está acompanhado";
            }

            if (idadeJoao >= 18 || estaAcompanhado == true)
            {
                Console.WriteLine("Pode entrar!");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
                Console.WriteLine(mensagemAdicional);
            }

            Console.WriteLine("Fim da execução. Pressione Enter para sair...");
            Console.ReadLine();
        }
    }
}
