namespace ex01salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Cadastro Funcionario CLT ====");
            FuncionarioCLTcs Clt = new FuncionarioCLTcs();
            Clt.ReceberDadosClt();
            Clt.MostrarDados();

            Console.WriteLine();

            Console.WriteLine("==== Cadastro Funcionario Comissionado ====");
            FuncionarioComissionado comissionado = new FuncionarioComissionado();
            comissionado.ReceberDadosComissionado();
            comissionado.MostrarDados();
        }
    }
}
