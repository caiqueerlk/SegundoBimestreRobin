using System;
using System.Collections.Generic;
using System.Text;

namespace ex01salario
{
    internal class FucionarioComissionado
    {
        class FuncionarioComissionado : Funcionario  
        {
           
            public double TotalVendas { get; set; }
            public double PercentualComissao { get; set; }
            public void ReceberDadosComissionado()
            {
                ReceberDados(); 

                Console.Write("Total de Vendas: ");
                TotalVendas = double.Parse(Console.ReadLine());

                Console.Write("Percentual de Comissão (%): ");
                PercentualComissao = double.Parse(Console.ReadLine());
            }

            public override double CalcularSalarioFinal()
            {
                return SalarioBase + (TotalVendas * PercentualComissao / 100);
            }

            public override void MostrarDados()
            {
                Console.WriteLine("\n--- Funcionário Comissionado ---");
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"Cargo: {Cargo}");
                Console.WriteLine($"Salário Base: {SalarioBase:C}");
                Console.WriteLine($"Total de Vendas: {TotalVendas:C}");
                Console.WriteLine($"Comissão ({PercentualComissao}%): {TotalVendas * PercentualComissao / 100:C}");
                Console.WriteLine($"Salário Final: {CalcularSalarioFinal():C}");
            }
        }
    }
}
