using System;

namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Pagamento via PIX ---");
            PagamentoPix pix = new PagamentoPix();
            pix.ReceberDadosPix();
            pix.ProcessarPagamento();
            pix.MostrarPagamento();

            Console.WriteLine();

            Console.WriteLine("--- Pagamento via Cartão de Crédito ---");
            PagamentoCartaoCredito cartao = new PagamentoCartaoCredito();
            cartao.ReceberDadosCartao();
            cartao.ProcessarPagamento();
            cartao.MostrarPagamento();
        }
    }
}