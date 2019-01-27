using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double comprimento, largura, area, perimetro;

            Console.Write("Informe o comprimento do retângulo: ");
            comprimento = ObterValor();

            Console.Write("Informe a largura do retângulo: ");
            largura = ObterValor();

            area = largura * comprimento;
            perimetro = (2 * comprimento) + (2 * largura);

            Console.WriteLine("A área do retângulo é {0}", area);
            Console.WriteLine("O perímetro do retângulo é {0}", perimetro);
        }

        static double ObterValor()
        {
            var valor = Console.ReadLine();
            return Convert.ToDouble(valor);
        }

    }

}
