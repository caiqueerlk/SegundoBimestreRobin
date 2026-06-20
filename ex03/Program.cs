namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Dados do Carro ---");
            Carro carro = new Carro();
            carro.ReceberDadosCarro();
            carro.MostrarDados();

            Console.WriteLine();

            Console.WriteLine("--- Dados da Moto ---");
            Moto moto = new Moto();
            moto.ReceberDadosMoto();
            moto.MostrarDados();

            Console.WriteLine();

            Console.WriteLine("--- Dados do Caminhão ---");
            Caminhao caminhao = new Caminhao();
            caminhao.ReceberDadosCaminhao();
            caminhao.MostrarDados();


        }
    }
}
