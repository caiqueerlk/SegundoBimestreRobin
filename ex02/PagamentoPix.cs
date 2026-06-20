using System;
using System.Collections.Generic;
using System.Text;

namespace ex02
{
    internal class PagamentoPix : Pagamento
    {
        public string ChavePix { get; set; }

        public void ReceberDadosPix()
        {
            base.ReceberDados();
            Console.Write("Chave PIX: ");
            ChavePix = Console.ReadLine() ?? string.Empty;
        }

        public override void ProcessarPagamento()
        {
            Console.WriteLine($"Processando pagamento via PIX para {NomeCliente} (chave: {ChavePix})...");
            Console.WriteLine($"Pagamento via PIX no valor de {Valor:C} concluído.");
        }

        public override void MostrarPagamento()
        {
            base.MostrarPagamento();
            Console.WriteLine($"Chave Pix: {ChavePix}");
            Console.WriteLine("Status: Aprovado instantaneamente");
        }
    }
}