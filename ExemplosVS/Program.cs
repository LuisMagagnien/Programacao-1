using System;

class Program
{
    static void Main()
    {
        string NomeCompleto = "Luis Antonio Magagnien";
        NomeCompleto = NomeCompleto.Replace("Antonio", "Lua");
        Console.WriteLine(NomeCompleto);

        bool isNomeEqual = (NomeCompleto == "Luis Antonio Magagnien");
        bool isNomeEqual2 = string.Equals(NomeCompleto, "Luis Lua Magagnien", StringComparison.Ordinal);

        Console.WriteLine($"Primeiro Resultado: {isNomeEqual}\nSegundo Resultado: {isNomeEqual2}");
    }
}

/* TIPOS NUMERICOS

sbyte: Armazena valores entre -128 e 127
short: Armazena valores entre -32,768 e 32,767
int: Armazena valores entre -2,147,483,648 e 2,147,483,647
long: Armazena valores entre -9,223,372,036,854,775.808 e 9,223,372,036,854,775,807

*/

/* float myFloat = 10f;
double myDouble = 5d;
decimal myDecimal = 7m;
int myInteger = 0;
*/