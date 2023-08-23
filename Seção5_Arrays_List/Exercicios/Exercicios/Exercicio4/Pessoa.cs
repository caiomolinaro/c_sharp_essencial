//a -) Primeiro crie uma classe chamada Pessoa.cs com duas propriedades (nome e idade) e um método Exibir()
//para imprimir o nome e a idade;



namespace Exercicio4
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string Exibir()
        {
            return Nome + " - " + Idade;
        }
    }
}
