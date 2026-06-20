using System;
using System.Collections.Generic;
using System.Text;

namespace ex01salario
{
    internal class FuncionarioCLTcs : Funcionario
    {
        public double Bonus { get; set; }
        public void ReceberDadosClt()
        {
            ReceberDados();
            Console.Write("Bonus: ");
            Bonus = double.Parse(Console.ReadLine());
        }
        public override double CalcularSalarioFinal()
        {
            return SalarioBase + Bonus;
        }
        public override void MostrarDados()
        {
            base.MostrarDados();
            Console.WriteLine($"Bônus: {Bonus:C}");
        }
    }
}
    