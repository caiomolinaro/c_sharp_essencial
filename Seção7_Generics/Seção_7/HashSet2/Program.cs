var timesSP = new HashSet<string> { "Santos", "Palmeiras", "São Paulo" };

var timesRJ = new HashSet<string> { "Vasco", "Flamengo", "Fluminense" };

var timesBA = new HashSet<string> { "Bahia", "Vitória", "Juazeiro" };

var timesMundiais = new HashSet<string> {"Santos", "Palmeiras", "São Paulo", "Flamengo"};

//incluindo mais um elemento
if (!timesSP.Contains("Corinthias"))
    timesSP.Add("Corinthias");


////removendo um elemnto
//var resultado = timesBA.Remove("Juazeiro");



//fazendo operações com conjuntos

//ver se é um subconjunto de outro

//if (timesSP.IsSubsetOf(timesMundiais))
//{
//    Console.WriteLine("timesSP é um subconjunto de timesMundiais");
//}


////ver se é um superconjunto

//if (timesMundiais.IsSupersetOf(timesSP))
//{
//    Console.WriteLine("timesMundiais é um subconjunto de timesSP");
//}


////ver se o conjunto compartilha elemento com outro

//if(timesRJ.Overlaps(timesMundiais))
//{
//    Console.WriteLine("Pelo menos um time do rj tem um mundial");
//}

////ver se dois conjuntos tem o mesmo elemento

//if(!timesSP.SetEquals(timesRJ))
//{
//    Console.WriteLine("Não contem os mesmos elementos");
//}




//////operações com conjuntos   
////timesSP.UnionWith(timesRJ);
////timesSP.UnionWith(timesBA);

////ExibirColecao(timesSP);

//////exibir ordenados
////var todosTimes = new SortedSet<string>(timesSP);
////ExibirColecao(todosTimes);


////intersecção
//timesSP.IntersectWith(timesMundiais);
//ExibirColecao(timesSP);


////diferença de dois conjuntos
//timesMundiais.ExceptWith(timesSP);
//ExibirColecao(timesMundiais);


//diferença com symemetricexcpetwith
timesMundiais.SymmetricExceptWith(timesSP);
ExibirColecao(timesMundiais);

//remover elementos
timesMundiais.Clear();


Console.ReadKey();

static void ExibirColecao<T>(IEnumerable<T> colecao)
{
    Console.WriteLine();
    foreach (var item in colecao)
    {
        Console.WriteLine(item);
    }
}