using Downcasting_Upcasting;

Forma circulo = new Circulo(10, 20);
Forma f = circulo; //upcasting

Circulo c = (Circulo) f; //downcasting

c.Desenhar();
c.PintarCirculo();

Console.WriteLine(c == f);
Console.WriteLine(c == circulo);

//upcasting converte um objeto de tipo especializado(classe derivada ou filha) para um tipo mais geral(classe base ou pai) - implicita
//downscasting converte um objeto de tipo geral(classe base) para um tipo mais especializado(classe filha) - explicita