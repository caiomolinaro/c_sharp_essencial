﻿Console.WriteLine("## Struct DateTime ##\n");

DateTime hoje = DateTime.Now;
Console.WriteLine($"hoje: {hoje}\n");

//criar uma data especifica usa formato: aaaa,mm,dd

//DateTime dataHoje = new DateTime(2023, 07, 26);
//Console.WriteLine(dataHoje);

////definir as horas
//DateTime dataHoraHoje = new DateTime(2023, 07, 26, 21, 10, 30);
//Console.WriteLine(dataHoraHoje);

//extrair informações da data atual
//Console.WriteLine(hoje.Year);
//Console.WriteLine(hoje.Month);
//Console.WriteLine(hoje.Day);
//Console.WriteLine(hoje.Hour);
//Console.WriteLine(hoje.Minute);
//Console.WriteLine(hoje.Second);
//Console.WriteLine(hoje.Millisecond);


//adicionando valores
//Console.WriteLine(hoje.AddDays(30));
//Console.WriteLine(hoje.AddMonths(1));
//Console.WriteLine(hoje.AddHours(2));
//Console.WriteLine(hoje.AddYears(5));

//obter o dia da semana e do ano
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

//data e hora no formato longo e curto
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());

Console.WriteLine(hoje.ToLongTimeString());
Console.WriteLine(hoje.ToShortTimeString());

Console.ReadLine();