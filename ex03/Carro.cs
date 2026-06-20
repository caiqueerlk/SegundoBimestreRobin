using System;
using System.Collections.Generic;
using System.Text;

namespace ex03
{
    internal class Carro : Veiculo
    {
        public int QuantidadePortas { get; set; }
        public void ReceberDadosCarro()
        {
            base.ReceberDados();
            Console.WriteLine("Quantidade portas: ");
            QuantidadePortas = int.Parse(Console.ReadLine());
        }
        public override double CalcularCustoManutencao()
        {
            return ValorBaseManutencao + 200;
        }
        public override void MostrarDados()
        {
            base.MostrarDados();
            Console.WriteLine($"Quantidade de Portas: {QuantidadePortas}");
        }
    }
}
