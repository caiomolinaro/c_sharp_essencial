﻿//Suponha que você possui uma lista de planetas com informações sobre o nome, diâmetro e massa de cada
//planeta.
//Crie um programa e implemente um método que recebe essa lista e um delegate Predicate<Planeta> para
//filtrar os planetas de acordo com um critério específico.

List<Planeta> planetas = new List<Planeta>
{
 new Planeta("Mercúrio", 4879, 3.301e23),
 new Planeta("Vênus", 12104, 4.867e24),
 new Planeta("Terra", 12756, 5.972e24),
 new Planeta("Marte", 6792, 6.39e23),
 new Planeta("Júpiter", 142984, 1.898e27),
 new Planeta("Saturno", 120536, 5.683e26),
 new Planeta("Urano", 51118, 8.681e25),
 new Planeta("Netuno", 49528, 1.024e26)
};

Predicate<Planeta> filtro = p => p.Diametro > 14000;
List<Planeta> planetasDiametro14 = FiltrarPlanetas(planetas, filtro);
foreach (Planeta planet in planetasDiametro14)
    Console.WriteLine(planet.Nome);


Console.ReadKey();

static List<Planeta> FiltrarPlanetas (List<Planeta> lista, Predicate<Planeta> filtro)
{
    List<Planeta> resultado = new List<Planeta>();
    foreach (Planeta planeta in lista)
    {
        if (filtro(planeta))
        {
            resultado.Add(planeta);
        }
    }
    return resultado;
}

class Planeta
{
    public string Nome { get; set; }
    public double Diametro { get; set; }
    public double Massa { get; set; }
    public Planeta(string nome, double diametro, double massa)
    {
        Nome = nome;
        Diametro = diametro;
        Massa = massa;
    }
}
