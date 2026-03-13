while (true)
{
    Console.Clear();

    Console.WriteLine("===============================");
    Console.WriteLine("Algoritimo de valor inical");
    Console.WriteLine("===============================");

    Console.ReadLine();

    Console.Write("Digite o valor A: ");

    int a = Convert.ToInt32(Console.ReadLine());
    int resultado = 1;

    for (int contador = a; contador >= 1; contador--)
    {
        {
            resultado = resultado * contador;
            if (contador > 1)
                Console.Write($"{contador} x ");
            else
                Console.Write($"{contador}");

        }
        continue;
    }

    Console.WriteLine($" = {resultado}");

    Console.ReadLine();

    Console.Write("DESEJA CONTINUAR? s/N ");
    string? desejaContinuar = Console.ReadLine();

    if (desejaContinuar?.ToUpper() != "S")
        break;
}