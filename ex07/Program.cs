using System;
using System.Collections.Generic;

namespace ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
            int opcao;

            do
            {
                Console.WriteLine("=== Opção ===");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Listar clientes");
                Console.WriteLine("3 - Buscar cliente por nome");
                Console.WriteLine("4 - Remover cliente");
                Console.WriteLine("5 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Cliente cliente = new Cliente();
                        Console.WriteLine("Nome: ");
                        cliente.Nome = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(cliente.Nome))
                        {
                            Console.WriteLine("Nome não pode ser vazio!");
                            break;
                        }
                        Console.Write("Telefone: ");
                        cliente.Telefone = Console.ReadLine();

                        Console.Write("Cidade: ");
                        cliente.Cidade = Console.ReadLine();

                        clientes.Add(cliente);
                        Console.WriteLine("Cliente cadastrado com sucesso!");
                        break;

                    case 2:
                        if (clientes.Count == 0)
                        {
                            Console.WriteLine("Nehum cliente foi cadastrado.");
                        }
                        else{
                            Console.WriteLine("\nLista de clientes:");
                            foreach(Cliente c in clientes)
                            {
                                Console.WriteLine($"{c.Nome} - {c.Telefone} - {c.Cidade}");
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Digite o nome para buscar: ");
                        string nomeBusca = Console.ReadLine();
                        Cliente encontrado = clientes.Find(c => c.Nome == nomeBusca);

                        if (encontrado != null)
                        {
                            Console.WriteLine($"Encontrado: {encontrado.Nome} - {encontrado.Telefone} - {encontrado.Cidade}");
                        }
                        else
                        {
                            Console.WriteLine("Não tem nenhum cliente cadastrado com esse nome.");
                        }
                        break;

                    case 4:
                        Console.Write("Digite o nome para remover: ");
                        string nomeremover = Console.ReadLine();
                        Cliente remover = clientes.Find(c => c.Nome == nomeremover);
                        if (remover != null)
                        {
                            clientes.Remove(remover);
                            Console.WriteLine("Cliente removido.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Saindo...");
                        break;

                }


            } while (opcao != 5);
        }
    }
}
