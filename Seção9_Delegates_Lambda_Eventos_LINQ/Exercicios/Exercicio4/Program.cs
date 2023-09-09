//Crie um programa onde um método que receba dois números inteiros e retorne o resultado da operação
//de adição ou subtração desses números, a ser definida em tempo de execução por um delegate Func<int, int,
//int>.

int x = 2;
int y = 3;

Func<int, int, int> operecao = (x, y) =>  x + y;

Console.WriteLine(Operacoes(x,y, operecao));

operecao = (x, y) => x - y;

Console.WriteLine(Operacoes(x,y, operecao));

Console.ReadKey();  

static int Operacoes(int x, int y, Func<int, int, int> operecao)
{
    return operecao(x, y);  
}