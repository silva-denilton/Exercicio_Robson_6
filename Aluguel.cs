using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Aluguel
    {
        public void Menu()
        {
            Console.WriteLine("Escolha uma opcão: ");
            Console.WriteLine("(1) para carro! ");
            Console.WriteLine("(2) para moto! ");
            Console.WriteLine("(3) para caminhão! ");
            char tipo = char.Parse(Console.ReadLine());
            if (tipo == '1')
            {
                Carro _carro = new Carro();
                Console.WriteLine("Digite o modelo do carro! ");
                string modeloCarro = Console.ReadLine();
                Console.WriteLine("Digite a placa do carro! ");
                string placaCarro = Console.ReadLine();
                Console.WriteLine("Digite o ano do carro! ");
                int anoCarro = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o preço da diaria do carro! ");
                _carro.preco = double.Parse(Console.ReadLine());
                Veiculos _veiculos = new Veiculos(modeloCarro, placaCarro, anoCarro, _carro.preco);
                Console.WriteLine("Digite a quantidade de dias que deseja alugar!");
                _carro.DiasAluguelCarro = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o numero de portas! ");
                _carro.NumeroPortas = int.Parse(Console.ReadLine());
                _veiculos.Mostrar();
                _carro.MostrarNumeroPortas();
                _carro.MostrarValor();
            }
            else
            {
                if (tipo == '2')
                {
                    Moto _moto = new Moto();
                    Console.WriteLine("Digite o modelo do moto! ");
                    string modeloMoto = Console.ReadLine();
                    Console.WriteLine("Digite a placa da moto! ");
                    string placaMoto = Console.ReadLine();
                    Console.WriteLine("Digite o ano do moto! ");
                    int anoMoto = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o preço da diaria da moto! ");
                    _moto.preco = double.Parse(Console.ReadLine());
                    Veiculos _veiculos = new Veiculos(modeloMoto, placaMoto, anoMoto, _moto.preco);
                    Console.WriteLine("Digite a quantidade de dias que deseja alugar!");
                    _moto.diasAluguelMoto = int.Parse(Console.ReadLine());
                 // Console.WriteLine("Digite quantas cilindradas você deseja! ");
                 // _moto.cilindrada = int.Parse(Console.ReadLine());
                    _veiculos.Mostrar();
                    _moto.MostrarCilindrada();
                    _moto.ValorPagar();

                }
                if (tipo == '3')
                {
                    Caminhao _caminhao = new Caminhao();
                    Console.WriteLine("Digite o modelo do caminhão! ");
                    string modeloCaminhao = Console.ReadLine();
                    Console.WriteLine("Digite a placa da caminhão! ");
                    string placaCaminhao = Console.ReadLine();
                    Console.WriteLine("Digite o ano do caminhão! ");
                    int anoCaminhao = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o preço da diaria do caminhão! ");
                    _caminhao.preco = double.Parse(Console.ReadLine());
                    Veiculos _veiculos = new Veiculos(modeloCaminhao, placaCaminhao, anoCaminhao, _caminhao.preco);
                    Console.WriteLine("Digite a quantidade de dias que deseja alugar!");
                    _caminhao.DiasAluguelCaminhao = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a capacidade da carga! ");
                    _caminhao.CapacidadeCarga = int.Parse(Console.ReadLine());
                    _veiculos.Mostrar();
                    _caminhao.MostrarCarga();
                    _caminhao.MostrarValor();
                }
            }
        }
    }
}
