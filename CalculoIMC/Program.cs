using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o peso em KG: ");
            float peso = float.Parse(Console.ReadLine());

            Console.Write("Informe a altura em metros: ");
            float altura = float.Parse(Console.ReadLine());

            float imc = (peso / (altura * 2));

            Console.WriteLine("Seu IMC é: {0}", imc);

            Console.ReadLine();
        }
    }
}
