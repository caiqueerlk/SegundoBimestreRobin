using System;

namespace ex02
{
    internal class PagamentoCartaoCredito : Pagamento
    {
        public string NumeroCartao { get; set; }
        public int QuantidadeParcelas { get; set; } = 1;
        public decimal ValorParcelas { get; set; }

        public void ReceberDadosCartao()
        {
            base.ReceberDados();
            Console.Write("Número do cartão: ");
            NumeroCartao = Console.ReadLine() ?? string.Empty;

            Console.Write("Quantidade de Parcelas: ");
            QuantidadeParcelas = int.Parse(Console.ReadLine());

            if (QuantidadeParcelas <= 0)
            {
                QuantidadeParcelas = 1;
            }
        }

        public override void ProcessarPagamento()
        {
            ValorParcelas = Valor / QuantidadeParcelas;
            Console.WriteLine($"Processando pagamento no cartão {NumeroCartao} em {QuantidadeParcelas}x para {NomeCliente}...");
            Console.WriteLine($"Pagamento no cartão no valor de {Valor:C} concluído.");
        }

        public override void MostrarPagamento()
        {
            base.MostrarPagamento();
            Console.WriteLine($"Quantidade de Parcelas: {QuantidadeParcelas}x");
            Console.WriteLine($"Valor da Parcela: {ValorParcelas:C}");
        }
    }
}