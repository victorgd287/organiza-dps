// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

//declaração


int primeiroValor = 0;

Console.WriteLine("digite o primeiro valor");
string texto1 = Console.ReadLine();
bool V1Valido = int.TryParse(texto1, out primeiroValor);
if (V1Valido == false) {
    Console.WriteLine("numero invalido");
    return; 
}
if (primeiroValor > 10){
    Console.WriteLine("numero invalido, acima de 10");
    return;
}


int segundoValor = 0;

Console.WriteLine("digite o segundo valor");
string texto2 = Console.ReadLine();
bool V2Valido = int.TryParse(texto2, out segundoValor);
if (V2Valido == false)
{
    Console.WriteLine("numero invalido");
    return;
}
if (segundoValor > 10)
{
    Console.WriteLine("numero invalido, acima de 10");
    return;
}
if (segundoValor < primeiroValor)
{
    Console.WriteLine("algo de errado não está certo");
    return;
}

//regras


int soma = primeiroValor + segundoValor;
int subtracao = primeiroValor - segundoValor;
int divisao = primeiroValor / segundoValor;
int multiplicacao = primeiroValor * segundoValor;
int resto = primeiroValor % segundoValor;


//resultado
    
Console.WriteLine("O numero primario é:" + (primeiroValor));
Console.WriteLine("O numero segundario é:" + (segundoValor));
Console.WriteLine("O resultado da soma dos valores é:" + (soma));
Console.WriteLine("O resultado da subtração dos valores é:" + (subtracao));
Console.WriteLine("O resultado da multiplicação dos valores é:" + (multiplicacao));
Console.WriteLine("O resultado da divisão dos valores é:" + (divisao));
Console.WriteLine("O resultado do resto da divisão dos valores é:" + (resto));
Console.WriteLine($"A divisão entre {primeiroValor} e {segundoValor} é {divisao} ");
string.Concat("A multiplicação entre", primeiroValor, " é", segundoValor, "é", multiplicacao);