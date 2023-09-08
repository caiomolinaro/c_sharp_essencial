using Exercicio_Delegate;

var listaDePessoas = Pessoa.GetPessoas();

//imprime o nome e idade de cada pessoa usando o delegate action <pessoa>
Action<Pessoa> imprimirNome = p => Console.WriteLine(p.Nome + " " + p.Idade );
listaDePessoas.ForEach(imprimirNome);

Console.WriteLine();

//filtra as pessoas maiores de 18 anos usando um delegate predicate<pessoa>
Predicate<Pessoa> filtrarIdadeMaior18 = p => p.Idade > 18;
var pessoasMaiores18 = listaDePessoas.FindAll(filtrarIdadeMaior18);
pessoasMaiores18.ForEach(imprimirNome);

Console.WriteLine();

//obtem o nome e idade da pessoa mais velha utilizando um delegate Func<Pessoa>
Func<Pessoa, int> obterIdade = p => p.Idade;
//var pessoaMaisVelha = listaDePessoas.MaxBy(obterIdade); outra forma de resolver
int idadeMax = listaDePessoas.Max(obterIdade);
var pessoaMaisVelha = listaDePessoas.Find(p => p.Idade == idadeMax);
Console.WriteLine(pessoaMaisVelha.Nome);

Console.ReadKey();