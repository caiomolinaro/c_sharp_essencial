using Indexers_Indexadores;

Time time = new Time();

time[1] = "Lakers";
time[3] = "Warriors";
time[5] = "Celtics";
time[7] = "Orlando";
time[-1] = "Bulls";
time[1000] = "Nuggets";


string valor1 = time[1];
string valor2 = time[3];
string valor3 = time[5];
string valor4 = time[7];
string valor5 = time[-1];
string valor6 = time[1000];

Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);
Console.WriteLine(valor5);
Console.WriteLine(valor6);

Console.ReadKey();

