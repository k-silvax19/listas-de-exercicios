while (true)
{
    Console.Clear();

    Console.WriteLine("==============================");
    Console.WriteLine("algoritmo para ler valores A, B, C ");
    Console.WriteLine("==============================");

    Console.ReadLine();

    Console.Write("Digite o valor A: ");
    decimal valorA = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Digite o valor B: ");
    decimal valorB = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Digite o Valor C: ");
    decimal valorC = Convert.ToDecimal(Console.ReadLine());

    Console.ReadLine();

    if (valorA + valorB < valorC)
    {
        Console.WriteLine("O valor da Soma e menor que C");
    }
    else
    {
        Console.WriteLine("O Valor da Soma não e maior que C");
    }

    Console.ReadLine();

    Console.Write("DESEJA CONTINUAR? s/N ");
    string? desejaContinuar = Console.ReadLine();

    if (desejaContinuar?.ToUpper() != "S")
        break;
}
