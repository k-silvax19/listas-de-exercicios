while (true)
{
    Console.Clear();

    Console.WriteLine("========================================");
    Console.WriteLine("Programa para Verificar se um numero e primo!");
    Console.WriteLine("========================================");

    Console.ReadLine();

    Console.Write("Digite um número: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    int divisor = 0;

    for (int contador = 1; contador <= numero; contador++)
    {
        if (numero % contador == 0)
        {
            divisor++;
        }
    }

    if (divisor == 2)
    {
        Console.WriteLine("O numero é primo");
    }
    else
    {
        Console.WriteLine("o numero não e primo");
    }

    Console.ReadLine();

    Console.Write("DESEJA CONTINUAR? s/N ");
    string? desejaContinuar = Console.ReadLine();

    if (desejaContinuar?.ToUpper() != "S")
        break;
}