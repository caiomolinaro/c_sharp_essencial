using Operador_is_as;

//Object carroObj = new Carro();

//var x = carroObj as string;

//if (x != null)
//{
//    Console.WriteLine("Converteu obj para string");
//}
//else
//{
//    Console.WriteLine("Conversão falhou");
//}


//Circulo circulo = new Circulo();
//Forma forma = circulo;

//Circulo c = forma as Circulo;

//if (c != null)
//{
//    c.PintarCirculo();
//}
//else
//{
//    Console.WriteLine("Falhou");
//}


Circulo circulo = new Circulo();
Forma forma = circulo;

if (forma is Circulo) 
{
    Console.WriteLine("Converteu forma para circulo");

    var tipo = forma as Circulo;
    tipo?.PintarCirculo();
}
else
{
    Console.WriteLine("Operação downcasting não foi possivel");
}

Console.ReadKey();

//class Carro
//{ }


//operador as é usado para realizar a conversão entre tipos de referencia ou tipos anulaveis compativeis
//operador is é usado para verificar se o tipo de um objeto é compativel com o tipo especificado ou não