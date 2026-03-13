using System.Numerics;

while (true)
{
    Console.Clear();

    Console.WriteLine("========================================");
    Console.WriteLine("Padaria Hotpão ");
    Console.WriteLine("========================================");

    Console.ReadLine();

    Console.Write("Quantos pães foram vendidos: ");
    decimal quantidadePaes = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Quantas broas foram vendidas: ");
    decimal quantidadeBroas = Convert.ToDecimal(Console.ReadLine());

    decimal valorPao = 0.12m;
    decimal valorBroa = 1.50m;

    decimal totalPao = quantidadePaes * valorPao;
    decimal totalBroa = quantidadeBroas * valorBroa;
    decimal totalArrecadado = totalPao + totalBroa;
    decimal poupanca = totalArrecadado * 0.10M;

    Console.WriteLine($"Total arrecadado: R${totalArrecadado:F2}");
    Console.WriteLine($"Valor da poupança: R${poupanca:F2}");

    Console.ReadLine();

    Console.Write("DESEJA CONTINUAR? s/N ");
    string? desejaContinuar = Console.ReadLine();

    if (desejaContinuar?.ToUpper() != "S")
        break;
}