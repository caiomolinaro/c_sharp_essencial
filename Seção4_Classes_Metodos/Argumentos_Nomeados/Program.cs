Email email = new();

email.Enviar("empresa@empresa.com", "Urgente", "Reunião de orçamento");

//argumentos nomeados
email.Enviar(titulo: "Urgente", destino: "empresa@empresa.com", assunto: "Reunião de orçamento");


Console.ReadKey();

public class Email
{
  public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"Para {destino} - {titulo} - Assunto: {assunto}");
    }
        
 }