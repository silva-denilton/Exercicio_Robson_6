using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Veiculos
    {
        public string Marca;        
        public string Modelo;
        public string Placa;
        public int Ano;
        public double PrecoDiaria;

        public Veiculos(string marca, string modelo, int ano, double precoDiaria)
        {
            Marca = marca;
            Modelo = modelo;

            Ano = ano;
            PrecoDiaria = precoDiaria;
        }
        public void Mostrar()
        {
            Console.WriteLine(Marca 
                + " "
                + Modelo 
                + ", Ano: " 
                + Ano
                + ", Preço da Diária: R$" + PrecoDiaria.ToString("F2"));

        }
    }
}
