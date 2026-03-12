while (true)
{
    Console.Clear();

    Console.WriteLine("========================================");
    Console.WriteLine("Calculadora De Consumo De Combustivel");
    Console.WriteLine("========================================");

    Console.ReadLine();

    Console.Write("Quilometragem Inicial: ");
    decimal kmInicial = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Quilometragem Final: ");
    decimal kmfinal = Convert.ToDecimal(Console.ReadLine());

    Console.Write("quantidade de combustível consumida durante a viagem (em litros): ");
    decimal ltViagem = Convert.ToDecimal(Console.ReadLine());

    decimal distancia = kmInicial - kmfinal;

    decimal percurso = distancia / ltViagem;

    Console.ReadLine();

    Console.WriteLine($"A distancia percorrida e: {distancia} km");

    Console.WriteLine($"o consumo e: {percurso:F2} km/L");

    Console.ReadLine();

    Console.Write("DESEJA CONTINUAR? s/N ");
    string? desejaContinuar = Console.ReadLine();

    if (desejaContinuar?.ToUpper() != "S")
        break;

}