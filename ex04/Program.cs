using Ex04;
using System.Collections.Generic;

int opcao = 0;
List<Aluno> listaDeAluno = new List<Aluno>();

do
{
    Console.WriteLine("\n===== MENU =====");
    Console.WriteLine("1 - Cadastrar um aluno");
    Console.WriteLine("2 - Listar todos os alunos cadastrados");
    Console.WriteLine("3 - Alterar dados de um aluno");
    Console.WriteLine("4 - Remover um aluno");
    Console.WriteLine("0 - Encerrar o programa");

    Console.Write("Digite a opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CadastrarAluno();
            break;

        case 2:
            ListarDados();
            break;

        case 3:
            AlterarDados();
            break;

        case 4:
            RemoverAluno();
            break;

        case 0:
            Console.WriteLine("Programa encerrado!");
            break;

        default:
            Console.WriteLine("Opção não existe!");
            break;
    }

} while (opcao != 0);

void CadastrarAluno()
{
    Aluno aluno = new Aluno();

    Console.Write("Digite o nome: ");
    aluno.Nome = Console.ReadLine();

    Console.Write("Digite o RA: ");
    string ra = Console.ReadLine();


    foreach (Aluno a in listaDeAluno)
    {
        if (a.RA == ra)
        {
            Console.WriteLine("RA já cadastrado!");
            return;
        }
    }

    aluno.RA = ra;

    Console.Write("Digite a idade: ");
    aluno.Idade = int.Parse(Console.ReadLine());

    listaDeAluno.Add(aluno);

    Console.WriteLine("Aluno cadastrado com sucesso!");
}

void ListarDados()
{
    if (listaDeAluno.Count == 0)
    {
        Console.WriteLine("Nenhum aluno cadastrado.");
        return;
    }

    foreach (Aluno aluno in listaDeAluno)
    {
        aluno.MostrarDados();
    }
}

void AlterarDados()
{
    Console.Write("Digite o RA a ser localizado: ");
    string ra = Console.ReadLine();

    bool encontrado = false;

    foreach (Aluno aluno in listaDeAluno)
    {
        if (aluno.RA == ra)
        {
            Console.Write("Digite o novo nome: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Digite a nova idade: ");
            aluno.Idade = int.Parse(Console.ReadLine());

            encontrado = true;
            Console.WriteLine("Dados alterados com sucesso!");
            break;
        }
    }

    if (!encontrado)
    {
        Console.WriteLine("Aluno não encontrado!");
    }
}

void RemoverAluno()
{
    Console.Write("Digite o RA do aluno a ser removido: ");
    string ra = Console.ReadLine();

    Aluno alunoRemover = null;

    foreach (Aluno aluno in listaDeAluno)
    {
        if (aluno.RA == ra)
        {
            alunoRemover = aluno;
            break;
        }
    }

    if (alunoRemover != null)
    {
        listaDeAluno.Remove(alunoRemover);
        Console.WriteLine("Aluno removido com sucesso!");
    }
    else
    {
        Console.WriteLine("Aluno não encontrado!");
    }
}