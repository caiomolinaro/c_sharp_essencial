﻿Console.WriteLine("## Conversão de tipos ##\n ");


//ToString

//int valorInt = 123;
//double valorDouble = 12.45;
//decimal valorDecimal = 12.45678m;

//string s1 = valorInt.ToString();
//string s2 = valorDouble.ToString();
//string s3 = valorDecimal.ToString();

//Console.WriteLine(s1);
//Console.WriteLine(s2);
//Console.WriteLine(s3);

//usar o metodo convert:

//int valorInt = 10;
//double valorDouble = 5.35;
//bool valorBool = true;

//Console.WriteLine(Convert.ToString(valorInt));
//Console.WriteLine(Convert.ToDouble(valorDouble));
//Console.WriteLine(Convert.ToString(valorBool));
//Console.WriteLine(Convert.ToInt32(valorDouble));


//erro de overflow exception
int varInt = 100000;
Console.WriteLine(Convert.ToByte(varInt));
Console.WriteLine(varInt);


Console.ReadLine();
