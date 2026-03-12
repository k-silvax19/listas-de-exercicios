while (true)
{
    Console.Clear();

    Console.WriteLine("========================================");
    Console.WriteLine("Algoritimo para ler dimensoes retangulares! ");
    Console.WriteLine("========================================");

    Console.ReadLine();

    Console.Write("Comprimento Do Terreno: ");
    decimal C = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Largura Do Terreno: ");
    decimal L = Convert.ToDecimal(Console.ReadLine());

    decimal area = C * L;

    Console.ReadLine();

    Console.WriteLine($"A area do terreno e: {area} m²");

    Console.ReadLine();

    Console.Write("DESEJA CONTINUAR? s/N ");
    string? desejaContinuar = Console.ReadLine();

    if (desejaContinuar?.ToUpper() != "S")
        break;
}