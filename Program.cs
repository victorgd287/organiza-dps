
using System.Data.Common;
//ler linhas do arquivo CSV
//PARA CADA LINHA, ULTILIZAR A FUNÇÃO SPLIT
//SPLIT: RECEBE UM CARACER E RETORNA ARRAY 
//ULTILIZAR UM FOR PARA MOSTRAR AS COLUNAS
void executar()
{
    string arq = @"C:\Users\2025105807\Documents\texto.csv";

    string[] linhas = lerarquivo(arq);

    foreach (var linha in linhas)
    {
      //  Console.WriteLine(linha);
        string[] colunas = linha.Split(';');
    //ultilizando for mostrar as colunas 

    for (int i =0; i < colunas.Length ; i++)
    {

            Console.WriteLine($"{colunas[i].PadRight(10)}  ");
   
    }
    }

}
string[] lerarquivo (string arq)
{
    try
    {
        string[] linhas = File.ReadAllLines(arq);
        return linhas;
        
    }
    catch 
    {
        Console.WriteLine($"erro ao ler arquivo");
        return new string[0];
    }
}
executar();