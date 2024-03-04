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
