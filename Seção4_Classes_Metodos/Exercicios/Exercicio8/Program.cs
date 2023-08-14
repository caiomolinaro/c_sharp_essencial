//Crie um objeto cliente da struct Cliente usando o construtor criado e exiba as informações chamando duas
//vezes o método ExibirInfo usando argumentos nomeados. Na primeira chamada informe todos os parâmetros e
//na segunda não informe o ano.

Cliente cliente = new("Caio", "teste@teste", 22 );

Cliente.ExibirInfo(email: cliente.Email, nome: cliente.Nome, Idade: cliente.Idade);

Cliente.ExibirInfo(email: cliente.Email, nome: cliente.Nome);
Console.ReadKey();

//Crie uma struct chamada Cliente e defina os campos Nome e Email do tipo string e a propriedade Idade
//do tipo int

public struct Cliente
{
    public string Nome;
    public string Email;
    private int idade;
    public int Idade
    {
        get { return idade; }
        set
        {   //- Validar a informação da Idade de forma que se a idade informada for menor que 18 seja atribuído 18 ao
            //valor da idade
            if (idade < 18)
                idade = 18;
            else
                idade = value;
        }
    }

    //Crie um construtor para a struct usando os campos Nome e Email e a propriedade Idade como parâmetros
    //de entrada para criar um objeto do tipo Cliente
    public Cliente (string nome, string email, int Idade) 
    {
        Nome = nome;
        Email = email;
        idade = Idade;
    }

    //Crie um método estático que retorne void chamado ExibirInfo que receba os parâmetros nome, email e
//idade e exiba as informações de Nome, Email e Idade.Defina idade como um parâmetro opcional.

    public static void ExibirInfo(string nome, string email, int Idade = 18)
    {
        Console.WriteLine($"{nome} / {email} / {Idade}");
    }
}