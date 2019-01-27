using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] minhaMatriz = new int[2, 4];
            int numero = 0;
            for (int linha = 0; linha <= 1; linha++)
            {
                for (int coluna = 0; coluna <= 3; coluna++)
                {
                    minhaMatriz[linha, coluna] = numero;
                    numero++;
                    Console.WriteLine("minhaMatriz[{0}, {1}] = {2}", linha, coluna, minhaMatriz[linha, coluna]);
                }
            }

            Console.WriteLine("Dimensões: {0}", minhaMatriz.Rank);
            Console.WriteLine("Tamanho: {0}", minhaMatriz.Length);
            
        }

        
    }
}
