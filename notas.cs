
// See https://aka.ms/new-console-template for more information
using System;

/*Console.WriteLine("Hello, World!");

//declaração

int primeiroValor = 0;
int segundoValor = 0;

//validação

Console.WriteLine("digite o primeiro valor");
string texto1 = Console.ReadLine();
bool V1Valido = int.TryParse(texto1, out primeiroValor);
if (V1Valido == false)
{
    Console.WriteLine("numero invalido");
    return;
}
if (primeiroValor > 10)
{
    Console.WriteLine("numero invalido, acima de 10");
    return;
}
if (primeiroValor < 1)
{
    Console.WriteLine("numero invalido, abaixo de 1");
}


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
if (segundoValor < 1)
{
    Console.WriteLine("numero invalido, abaixo de 1");
}

if (segundoValor < primeiroValor)
{
    Console.WriteLine("primeiro valor não pode ser maior que o segundo");
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
string.Concat("A multiplicação entre", primeiroValor, " é", segundoValor, "é", multiplicacao);*/

float primeiraNota = 0;
float segundaNota = 0;
float faltasTotais = 0;

Console.WriteLine("Digite o nome do Aluno");
string Nome = Console.ReadLine();
if (string.IsNullOrEmpty(Nome))
{
    Console.WriteLine("é necessario digitar o Nome");
    return; 
}

Console.WriteLine("Digite a primeira Nota do aluno");
string Nota1 = Console.ReadLine();
bool primeiraNotaValida = float.TryParse(Nota1, out primeiraNota);
if (primeiraNotaValida = false)
{
    Console.WriteLine("numero invalido");
    return;
}
if (primeiraNota > 10)
{
    Console.WriteLine("numero acima do permitido");
    return;
}



Console.WriteLine("Digite a segunda Nota do Aluno");
string Nota2 = Console.ReadLine();
bool segundaNotaValida = float.TryParse(Nota2, out segundaNota);
if(segundaNotaValida == false)
{
    Console.WriteLine("numero invalido");
}
if (segundaNota > 10)
{
    Console.WriteLine("numero acima do permitido");
    return;
}


Console.WriteLine("Digite a quantidade de faltas do Aluno");
string Faltas = Console.ReadLine();
bool faltasValida = float.TryParse(Faltas, out faltasTotais);




Console.WriteLine(Nome);
Console.WriteLine(Nota1);
Console.WriteLine(Nota2);
Console.WriteLine(faltasTotais);





