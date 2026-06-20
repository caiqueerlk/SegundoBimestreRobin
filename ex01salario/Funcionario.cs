using System;
using System.Collections.Generic;
using System.Text;

namespace ex01salario
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double SalarioBase { get; set; }
        public void ReceberDados()
        {
            Console.Write("Nome: ");
            Nome = Console.ReadLine();

            Console.Write("Cargo: ");
            Cargo = Console.ReadLine();

            Console.Write("Salario base: ");
            SalarioBase = double.Parse(Console.ReadLine());
        }
        public virtual double CalcularSalarioFinal()
        {
            return SalarioBase;
        }
        public virtual void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salário Final: {CalcularSalarioFinal():C}");
        }

    }
}
