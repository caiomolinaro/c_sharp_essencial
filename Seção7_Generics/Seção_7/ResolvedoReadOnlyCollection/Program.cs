//resolvendo o problema de items complexos no readonlycollection


using System.Collections.ObjectModel;

public class GerenciaExoPlanetas
{
    private List<ExoPlaneta> exoPlanetas = ExoPlaneta.GetExoPlanetas();

    public ReadOnlyCollection<ExoPlaneta> ExoPlanetas
    {
        get { return exoPlanetas.AsReadOnly(); } //acesso controlado
    }

    public void AdicionaPlaneta(ExoPlaneta planeta)
    {
        exoPlanetas.Add(planeta); //pra alguem incluir algo só usando esse metodo
    }
}
public class ExoPlaneta
{
    public string? Nome { get; set; }
    public static List<ExoPlaneta> GetExoPlanetas()
    {
        return new List<ExoPlaneta>()
            {
                new ExoPlaneta() {Nome = "Proxima centauri b"},
                new ExoPlaneta() {Nome = "Kepler 186-f"},
                new ExoPlaneta() {Nome = "Gliesi 1061-c" },
            };
    }
}