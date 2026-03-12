while (true)
{
    Console.Clear();

    Console.WriteLine("==============================");
    Console.WriteLine("Converção de Celsius para Fahrenheint");
    Console.WriteLine("==============================");

    Console.ReadLine();

    Console.Write("Digite os Celsius: ");
    decimal C = Convert.ToDecimal(Console.ReadLine());

    Console.ReadKey();

    decimal Fahrenheint = (9m / 5m) * C + 32;

    Console.WriteLine($"O resultado da conversão: {Fahrenheint}");

    Console.ReadLine();

    Console.Write("DESEJA CONTINUAR? s/N ");
    string? desejaContinuar = Console.ReadLine();

    if (desejaContinuar?.ToUpper() != "S")
        break;
}
