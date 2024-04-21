using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Caminhao
    {
        public double CapacidadeCarga;
        public int DiasAluguelCaminhao;
        public double preco;

        public void MostrarCarga()
        {
            Console.WriteLine("Capacidade da carga: " + CapacidadeCarga);

        }
        public void MostrarValor()
        {
            Aluguel aluguel = new Aluguel();
            double valor = DiasAluguelCaminhao * preco;
            Console.WriteLine("Valor a pagar: $" + valor);
        }
    }
}
