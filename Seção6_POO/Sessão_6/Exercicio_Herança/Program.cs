using Exercicio_Herança;

Console.WriteLine("\nConta Corrente: Numero: 111 Titular: Maria");

Conta conta = new();
conta.Numero = 111;
conta.Titular = "Maria";

Console.WriteLine("Depositar R$ 1.000,00");
conta.Depositar(1000);
Console.WriteLine("Sacar R$ 100,00");
conta.Sacar(100);
Console.WriteLine($"Saldo da Conta: {conta.Saldo.ToString("c")}");

Console.WriteLine("Sacando R$ 2,000,00");
conta.Sacar(2000);
Console.WriteLine($"Saldo da Conta: {conta.Saldo.ToString("c")}");

Console.WriteLine("\nConta Poupança Numero: 222 Titular: José");
ContaPoupanca contapoupanca = new();
contapoupanca.Numero = 222;
contapoupanca.Titular = "José";

Console.WriteLine("Depositar R$ 1.000,00");
contapoupanca.Depositar(1000);
Console.WriteLine($"Saldo da Conta: {contapoupanca.Saldo.ToString("c")}");
Console.WriteLine("Sacar R$ 100,00");
contapoupanca.Sacar(100);
Console.WriteLine($"Saldo da Conta: {contapoupanca.Saldo.ToString("c")}");

Console.WriteLine("Sacando R$ 2,000,00");
contapoupanca.Sacar(2000);
Console.WriteLine($"Saldo da Conta: {contapoupanca.Saldo.ToString("c")}");

Console.WriteLine("\nConta Investimentos Numero: 333 Titular: Caio");
ContaInvestimento containvestimentos = new();
containvestimentos.Numero = 222;
containvestimentos.Titular = "Caio";

Console.WriteLine("Depositar R$ 1.000,00");
containvestimentos.Depositar(1000);
Console.WriteLine($"Saldo da Conta: {containvestimentos.Saldo.ToString("c")}");
Console.WriteLine("Sacar R$ 100,00");
containvestimentos.Sacar(100);
Console.WriteLine($"Saldo da Conta: {containvestimentos.Saldo.ToString("c")}");

Console.WriteLine("Sacando R$ 2,000,00");
containvestimentos.Sacar(2000);
Console.WriteLine($"Saldo da Conta: {containvestimentos.Saldo.ToString("c")}");

Console.ReadKey();