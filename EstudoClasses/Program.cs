using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Carro carro = new Carro();
            carro.Marca = "Renault";
            Dono donoJoao = new Dono();
            donoJoao.Nome = "João";
            donoJoao.Idade = 30;
            Dono donoMaria = new Dono();
            donoMaria.Nome = "Maria";
            donoMaria.Idade = 20;
            carro.AdicionarAntigDono(donoJoao);
            carro.AdicionarAntigDono(donoMaria);

            foreach (Dono dono in carro.GetAntigosDonos())
            {
                Console.WriteLine("Um dos antigos donos é {0} com idade: {1}", dono.Nome, dono.Idade);
            }
            /*
            Console.WriteLine(carro.Ligar());
            Console.WriteLine("Este carro tem {0} portas", carro.NumeroPortas);

            Carro carro2 = new Carro("Astra");
            Console.WriteLine("Este outro carro se chama {0}", carro2.Nome);

            Carro carro3 = new Carro("Ford", 2);
            Console.WriteLine("Este outro carro é da marca {0} e tem {1} portas", carro3.Marca, carro3.NumeroPortas);

            Carro carro4 = new Carro(6);
            Console.WriteLine("Este carro tem {0}", carro4.NumeroPortas);

            Carro carro5 = new Carro(nome: "KA", marca: "Ford", quantidadePortas: 2);
            Console.WriteLine("Este carro é da marca {0}, modelo {1} e tem {2} portas", carro5.Marca, carro5.Nome, carro5.NumeroPortas);

            Carro carro6 = new Carro
            {
                Nome = "Corola",
                Marca = "Toyota",
                NumeroPortas = 4,
                Potencia = 2.0
            };
            Console.WriteLine("Este carro se chama {0}, é da marca {1}, possui {2} portas e tem potência {3}", carro6.Nome, carro6.Marca, carro6.NumeroPortas, carro6.Potencia);

            Carro carroFord = new Carro();
            carroFord.Nome = "KA";
            carroFord.Marca = "Ford";
            Console.WriteLine(carroFord.Ligar());

            Veiculo meuCarro = new Carro();
            Veiculo minhaMoto = new Moto();
            Veiculo meuCaminhao = new Caminhao();
            Console.WriteLine("Ligando o carro: {0}", meuCarro.Ligar());
            Console.WriteLine("Desligando o carro: {0}", meuCarro.Desligar());
            Console.WriteLine("Abastecendo o carro: {0}", meuCarro.Abastecer());

            Console.WriteLine("Ligando a moto: {0}", minhaMoto.Ligar());
            Console.WriteLine("Desligando a moto: {0}", minhaMoto.Desligar());
            Console.WriteLine("Abastecendo a moto: {0}", minhaMoto.Abastecer());

            Console.WriteLine("Ligando o caminhão: {0}", meuCaminhao.Ligar());
            Console.WriteLine("Desligando o caminhão: {0}", meuCaminhao.Desligar());
            Console.WriteLine("Abastecendo o caminhão: {0}", meuCaminhao.Abastecer());
            Console.WriteLine("Desabastecendo o caminhão: {0}", meuCaminhao.Desabastecer());
            

            */

            Console.ReadKey();
        }
    }
}

