namespace Exemplo_ReadOnlyCollection
{
    public class ExoPlaneta
    {
        public string? Nome {  get; set; }
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
}
