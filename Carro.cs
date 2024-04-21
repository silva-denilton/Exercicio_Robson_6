using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Carro 
    {
        public int NumeroPortas;
        public int DiasAluguelCarro;
        public double preco;

        public void MostrarNumeroPortas()
        {

            Console.WriteLine("Numero de portas: " + NumeroPortas);

        }
        public void MostrarValor() { 
        Aluguel aluguel = new Aluguel();
        double valor = DiasAluguelCarro * preco;
        Console.WriteLine("Valor a pagar: $" + valor);
        }
    }
}
