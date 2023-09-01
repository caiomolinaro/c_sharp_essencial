using Polimorfismo;

var figuras = new List<Figura>
{
    new Triangulo(),
    new Circulo()
};

foreach (var figura in figuras)
{
    figura.Desenhar();
}




Console.ReadKey();  



/*
 Polimorfismo é o principio pelo qual duas ou mais classes derivadas de uma mesma superclasse
podem invocar metodos que tem a mesma identificação (assinatura) mas comportamentos distintos,
especializados para cada classe derivada, usando para tanto uma referencia a um objeto do tipo
da superclasse
 

1- Polimorfismo em tempo de compilação (overloading ou sobrecarga)

2- Polimofirsmo em tempo de execução (overriding ou sobrecarga) = virtual e override
 */