using System;

class Program
{
    static void Main()
    {
        string nomecompleto = "Luis Magagnien";
        nomecompleto = nomecompleto.Replace("Luis", "Antonio");
        Console.WriteLine(nomecompleto);

        // Comparação de Strings

        bool isNomeEqual = (nomecompleto == "Luis Magagnien");
        bool isNomeEqual2 = string.Equals(nomecompleto, "Luis Magagnien", StringComparison.Ordinal);

        Console.WriteLine(isNomeEqual);
        Console.WriteLine(isNomeEqual2);
    }
}
