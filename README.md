# organiza-dps
vagabundo
//declaração 
int primeiroValor = 10;
int segundoValor = 5;

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
