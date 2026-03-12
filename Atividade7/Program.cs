while (true)
{
    Console.Clear();

    Console.WriteLine("========================================");
    Console.WriteLine("Calculadora de Media Ponderada");
    Console.WriteLine("========================================");

    Console.ReadLine();

    Console.Write("Prova 1: ");
    decimal pv1 = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Qual é o peso da Prova 1: ");
    decimal pesoPv1 = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Prova 2: ");
    decimal pv2 = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Qual é o peso da Prova 2: ");
    decimal pesoPv2 = Convert.ToDecimal(Console.ReadLine());

    decimal Resultado1 = (pv1 * pesoPv1 + pv2 * pesoPv2) / (pesoPv1 + pesoPv2);

    Console.ReadLine();

    Console.WriteLine($"O resultado é: {Resultado1}");

    Console.ReadLine();

    Console.Write("DESEJA CONTINUAR? s/N ");
    string? desejaContinuar = Console.ReadLine();

    if (desejaContinuar?.ToUpper() != "S")
        break;
}