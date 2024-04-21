using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Moto
    {
        public int cilindrada = 150;
        public int diasAluguelMoto;
        public double preco;

        public void MostrarCilindrada()
        {
            Console.WriteLine("Cilindrada: " + cilindrada);
        }
        public void ValorPagar()
        {
            Aluguel aluguel = new Aluguel();
            double valor = diasAluguelMoto * preco;
            Console.WriteLine("Valor a pagar: $" + valor);
        }
    }
}
