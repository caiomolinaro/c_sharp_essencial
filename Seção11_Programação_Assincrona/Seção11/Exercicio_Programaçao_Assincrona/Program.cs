await ExecutaOperacaoAsync();

Console.ReadKey();

static async Task ExecutaOperacaoAsync()
{
    //criando um cancelationtokensource
    var tempo = 30;
    var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(tempo));

    Console.WriteLine("Download iniciado");
    Console.WriteLine($"Cancelando operação após {tempo} segundos");

	try
	{
		using var httpClient = new HttpClient();
        var destino = @"A:\dados";

		var response = await httpClient.GetAsync("https://www.macoratti.net/dados/Poesia.txt",
							HttpCompletionOption.ResponseHeadersRead,
							cancellationTokenSource.Token); //download do arquivo

		var totalBytes = response.Content.Headers.ContentLength; //tamanho do arquivo em bytes
		var readBytes = 0L; // L = tipo long

		await using var fileStream = new FileStream(destino, FileMode.Create,
													FileAccess.Write);

		await using var contentStream = await response.Content.ReadAsStreamAsync(cancellationTokenSource.Token);


		var buffer = new byte[81920];
		int bytesRead;

		while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length, cancellationTokenSource.Token)) > 0)
		{
			await fileStream.WriteAsync(buffer, 0, bytesRead, cancellationTokenSource.Token);
			readBytes += bytesRead;
			Console.WriteLine($"Progresso: {readBytes}/{totalBytes}");
		}
    }
	catch(OperationCanceledException ex)
	{
		if((cancellationTokenSource.IsCancellationRequested))
		{
			Console.WriteLine("Download cancelado por tempo limite: " + ex.Message );
		}
        else
        {
			Console.WriteLine("Tempo limite para download atingido");
        }
    }
	catch(HttpRequestException ex)
	{
        Console.WriteLine("Ocorreu um erro de rede: " + ex.Message);

    }
	catch (Exception ex)
	{
		Console.WriteLine("Ocorreu um erro desconhecido: " + ex.Message);
	}
	finally
	{
		Console.WriteLine("Download concluido");
    };
}