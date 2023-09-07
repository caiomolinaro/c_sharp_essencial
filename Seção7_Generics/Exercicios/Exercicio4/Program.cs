﻿//implemente um programa que verifica se uma expressão matemática contém parênteses
//balanceados seguindo os seguintes passos:
//1.Crie uma variável do tipo Stack<char> para armazenar os parênteses abertos.
//2. Percorra cada caractere da expressão matemática.
//3. Se o caractere for um parêntese aberto ( '(', '{', '['), adicione - o à pilha.
//4.Se o caractere for um parêntese fechado ( ')', '}', ']' ), verifique se a pilha não está vazia e se o último
//parêntese aberto adicionado na pilha corresponde ao parêntese fechado atual. Se sim, remova o
//último parêntese aberto da pilha. Caso contrário, a expressão matemática não contém parênteses
//balanceados.
//5. Após percorrer todos os caracteres da expressão matemática, verifique se a pilha está vazia. Se estiver
//vazia, a expressão matemática contém parênteses balanceados. Caso contrário, a expressão não é
//balanceada.


string expressao = "(1 + 2) * 3) - 4";
bool balenceada = EstaBalanceada(expressao);

Console.WriteLine($"A expressão  {expressao} {(balenceada ? "esta balanceada" : "não esta balanceada")}.");
Console.ReadKey();

static bool EstaBalanceada(string expression)
{
    Stack<char> stack = new Stack<char>();
    foreach (char c in expression)
    {
        if (c == '(' || c == '{' || c == '[')
        {
            stack.Push(c);
        }
        else if (c == ')' || c == '}' || c == ']')
        {
            if (stack.Count == 0)
            {
                return false;
            }
            char ultimoParenteses = stack.Pop();
            if ((c == ')' && ultimoParenteses != '(') || (c == '}' && ultimoParenteses != '{') || (c == ']' && ultimoParenteses != '['))
            {
                return false;
            }
        }
    }
    return stack.Count == 0;
}
