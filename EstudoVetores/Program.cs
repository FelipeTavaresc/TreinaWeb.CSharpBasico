﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] meuVetor = new int[10];
            for (int i = 0; i < 9; i++)
            {
                meuVetor[i] = i + 1;
                Console.WriteLine("Posição {0} = {1}", i, meuVetor[i]);
            }
            Console.ReadKey();
        }
    }
}
