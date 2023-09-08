//metodos de extensão: perimitem estender a funcionalidade de um tipo existente sem criar um
//novo tipo derivado, recompilar ou modificar o tipo original

//são uteis para estender a funcionalidade de tipos existentes, como classes da biblioteca padrão ou classes definidas por outras bibliotecas de terceiros

//roteiro de criação:
//criar uma classe estática para conter o metodo de extensão, essa classe deve estar visivel para o código cliente 
//implemente o método de extensão como um metodo estatico como pelo menos a mesma visibilidade da classe que o contém
//o primeiro parametro do método especifica o tipo no qual o metodo opera. ele deve ser precedido pelo modificador this
//no codigo de chamada, adicione uma diretiva using para especificar o namespace que contem a classe do método de extensão
//chame os metodos como se fossem metodos de instancia no tipo

using Métodos_De_Extensão;

string texto = "Usando metodos de extensão";

string textoInvertido = texto.InverteString();

Console.WriteLine(texto);

Console.WriteLine(textoInvertido);