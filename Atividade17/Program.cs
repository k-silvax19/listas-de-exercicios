using System.Xml.Serialization;

while (true)
{
    Console.Clear();

    Console.WriteLine("==============================");
    Console.WriteLine("Algoritimos de valores inteiros");
    Console.WriteLine("==============================");

    Console.Write("Digite o valor A: ");
    int ValorA = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o valor B: ");
    int ValorB = Convert.ToInt32(Console.ReadLine());

    Console.ReadLine();

    int C;

    if (ValorA == ValorB)
    {
        C = ValorA + ValorB;
        Console.WriteLine($"O Valor C e: {C}");
    }
    else
    {
        C = ValorA * ValorB;
        Console.WriteLine($"O Valor C e: {C}");
    }

    Console.ReadLine();


    Console.Write("DESEJA CONTINUAR? s/N ");
    string? desejaContinuar = Console.ReadLine();

    if (desejaContinuar?.ToUpper() != "S")
        break;

}