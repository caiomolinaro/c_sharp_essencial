﻿try
{
    Console.WriteLine("Digite o nome do arquivo");
    string? arquivo = Console.ReadLine();
    Console.WriteLine("Informe a url do site");
    string? url = Console.ReadLine();
    Console.WriteLine("Aguarde");

    HttpClient cliente = new HttpClient();
    HttpResponseMessage response = cliente.GetAsync(url + arquivo).Result;

    if (response.IsSuccessStatusCode)
    {
        Console.WriteLine("Sucesso");
        Console.WriteLine("Código de status: " + response.StatusCode);
    }
    else
    {
       throw new HttpRequestException("Erro: " + (int)response.StatusCode);
    }
}
catch(HttpRequestException ex) when (ex.Message.Contains("404"))
{
    Console.WriteLine("Página não encontrada");
}
catch (HttpRequestException ex) when (ex.Message.Contains("401"))
{
    Console.WriteLine("Acesso não autorizado");
}
catch (HttpRequestException ex) when (ex.Message.Contains("400"))
{
    Console.WriteLine("Bad request error");
}
catch (HttpRequestException ex) when (ex.Message.Contains("500"))
{
    Console.WriteLine("Erro interno do servidor");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}
finally
{
    Console.WriteLine("Programa concluido");
}