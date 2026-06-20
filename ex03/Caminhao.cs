using System;
using System.Collections.Generic;
using System.Text;

namespace ex03
{
    internal class Caminhao : Veiculo
    {
        public double CapacidadeCarga { get; set; }
        public void ReceberDadosCaminhao()
        {
            base.ReceberDados();
            Console.WriteLine("Capacidade Carga: ");
            CapacidadeCarga = double.Parse(Console.ReadLine());
        }
        public override double CalcularCustoManutencao()
        {
            return ValorBaseManutencao + 500;
        }
        public override void ReceberDados()
        {
            base.ReceberDados();
            Console.WriteLine($"Capacidade Carga: {CapacidadeCarga} ");
        }
    }
}
