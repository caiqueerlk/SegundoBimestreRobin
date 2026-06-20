using System;
using System.Collections.Generic;
using System.Text;

namespace ex03
{
    internal class Veiculo
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double ValorBaseManutencao { get; set; }

        public virtual void ReceberDados()
        {
            Console.Write("Modelo: ");
            Modelo = Console.ReadLine();

            Console.Write("Ano: ");
            Ano = int.Parse(Console.ReadLine());

            Console.Write("Valor base de manutenção: R$ ");
            ValorBaseManutencao = double.Parse(Console.ReadLine());
        }
        public virtual double CalcularCustoManutencao()
        {
            return ValorBaseManutencao;
        }
        public virtual void MostrarDados()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Custo de Manutenção: R$ {CalcularCustoManutencao():F2}");
        }
    }

}

