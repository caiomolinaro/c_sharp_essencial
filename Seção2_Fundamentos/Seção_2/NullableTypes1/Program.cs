Console.WriteLine("## Nullable Types ##\n");

//Nullable<int> i = null;
//Nullable<double> d = null;
//Nullable<bool> b = null;

//int? i = null;
//double? d = null;
//bool? b = null;

//Console.WriteLine(i);
//Console.WriteLine(d);
//Console.WriteLine(b);

//int? a = null;

//int b = a ?? 0;

//int? x = 4;
//int? y = 3;
//int? z = x * y;

int? b = null;
if(b.HasValue)
{
    Console.WriteLine($"B = {b.Value}");
}
else
{
    Console.WriteLine("B não possui um valor(null)");
}


Console.ReadLine();