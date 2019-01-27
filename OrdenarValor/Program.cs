using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarValor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor;
            int n;

            Console.Write("Informe a quantidade de elementos que serão informados: ");
            n = ObterValor();

            vetor = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Informe o elemento {0} do vetor: ", i+1);
                var valor = ObterValor();

                vetor[i] = valor;
            }

            Ordenar(vetor);

            Console.WriteLine("Vetor Ordenado: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }

        static int ObterValor()
        {
            var valor = Console.ReadLine();
            return Convert.ToInt32(valor);
        }

        static void Ordenar(int[] vetor)
        {
            int aux;

            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = i; j < vetor.Length; j++)
                {
                    if (vetor[i] > vetor[j])
                    {
                        aux = vetor[j];

                        vetor[j] = vetor[i];

                        vetor[i] = aux;
                    }
                }
            }
        }
    }
}
