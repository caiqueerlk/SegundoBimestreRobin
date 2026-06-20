using System;

namespace ex03
{
    internal class Moto : Veiculo
    {
        public int Cilindradas { get; set; }

        public void ReceberDadosMoto()
        {
            base.ReceberDados();
            Console.Write("Cilindradas: ");
            Cilindradas = int.Parse(Console.ReadLine());
        }

        public override double CalcularCustoManutencao()
        {
            return ValorBaseManutencao + 100;
        }

        public override void MostrarDados()
        {
            base.MostrarDados();
            Console.WriteLine($"Cilindradas: {Cilindradas}");
        }
    }
}