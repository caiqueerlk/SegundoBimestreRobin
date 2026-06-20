using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ex02
{
    internal class Pagamento
    {
        public string NomeCliente { get; set; }
        public decimal Valor { get; set; }

        public virtual void ReceberDados()
        {
            Console.Write("Nome do cliente: ");
            NomeCliente = Console.ReadLine();

            Console.Write("Valor do pagamento: ");
            Valor = Convert.ToDecimal(Console.ReadLine());
        }

        public virtual void ProcessarPagamento()
        {
            Console.WriteLine("Pagamento processado com sucesso!");
        }

        public virtual void MostrarPagamento()
        {
            Console.WriteLine($"Cliente: {NomeCliente}");
            Console.WriteLine($"Valor: R$ {Valor:F2}");
        }

    }
}
