Console.WriteLine("## Conversão de tipos ##\n");

//conversão implicita

//int varInt = 100;
//double varDouble = varInt;

//Console.WriteLine(varDouble);

//int numeroInt = 2145678;
//int numeroLong = numeroInt;
//float numeroFloat = numeroInt;
//double numeroDouble = numeroInt;
//decimal numeroDecimal = numeroInt;

//Console.WriteLine(numeroInt);
//Console.WriteLine(numeroLong);
//Console.WriteLine(numeroFloat);
//Console.WriteLine(numeroDouble);
//Console.WriteLine(numeroDecimal);




//conversão explicita

double varDouble = 12.456; //8 bytes
int varInt = (int)varDouble; //4 bytes

Console.WriteLine(varInt);

int num1 = 10;
int num2 = 4;

float resultado = (float) num1 / num2;

Console.WriteLine(resultado);

Console.ReadLine();