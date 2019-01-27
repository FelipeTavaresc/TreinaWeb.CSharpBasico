﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> listaNumeros = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                listaNumeros.Add(i);
            }
            Console.Write("O número 10 está no índice: {0}", listaNumeros.IndexOf(10));
            foreach (int numero in listaNumeros)
            {
                Console.WriteLine("{0}", numero);
            }
            */
            /*
            Dictionary<string, string> meuDicionario = new Dictionary<string, string>();
            meuDicionario.Add("Adicionar", "Adicinar significa somar");
            meuDicionario.Add("Subtrair", "Subtrair significa diminuir");

            foreach (string chave in meuDicionario.Keys)
            {
                Console.WriteLine("{0} significa {1}", chave, meuDicionario[chave]);
            }
            */

            Dictionary<int, string> meuDicionario = new Dictionary<int, string>();
            meuDicionario.Add(1, "Número baixo");
            meuDicionario.Add(5, "Número médio");
            meuDicionario.Add(10, "Número alto");

            foreach (int chave in meuDicionario.Keys)
            {
                Console.WriteLine("{0} é um {1}", chave, meuDicionario[chave]);   
            }
            Console.ReadKey();
        }
    }
}
