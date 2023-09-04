Teste teste = new Teste();

int i1 = 10;
int i2 = 10;

float f1 = 10;
float f2 = 10;

string s1 = "10";
string s2 = "10";

teste.Comparar(i1, i2);
teste.Comparar(f1, f2);
//teste.Comparar(s1, s2);
//teste.Comparar(s1, f2);

Console.ReadKey();


public class Teste
{
    public void Comparar<T1, T2>(T1 p1, T2 p2) where T1 : struct where T2: struct
    {
        Console.WriteLine($"Os tipos: {p1.GetType()} e {p2.GetType()}");
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais? {resultado}");
    }
}


//Em C# Generics significa não ser especifico para um determinado tipo de dados
//O Recurso Generics permite que classes, métodos e interfaces possam ser parametrizados por tipo

//Principais beneficios do Generics são:
//-1 Reutilização de código,
//-2 Segurança de tipo (type safety),
//-3 Desempenho (evita as operações e boxing e unboxing)

