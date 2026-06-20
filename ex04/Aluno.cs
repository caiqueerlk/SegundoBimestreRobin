namespace Ex04
{
    internal class Aluno
    {
        public string RA { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome} RA: {RA} Idade: {Idade}");
        }
    }
}