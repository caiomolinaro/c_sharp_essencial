using Exemplo_ReadOnlyCollection;
using System.Collections.ObjectModel;

var exoPlanetas = new ReadOnlyCollection<ExoPlaneta>(ExoPlaneta.GetExoPlanetas());

//alterações nao permitidas
//exoPlanetas[0] = "kepler--442b";


exoPlanetas[0].Nome = "Kepler-442b";

foreach (var item in exoPlanetas)
    Console.WriteLine(item.Nome);


Console.ReadKey();  

//quando for um tipo complexo, exemplo uma classe, algo definido pelo user os items do readonlycollection podem ser modificados