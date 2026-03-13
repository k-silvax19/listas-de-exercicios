while (true)
{
    Console.Clear();

    Console.WriteLine("===============================");
    Console.WriteLine("Algoritmo de sequência Fibonacci");
    Console.WriteLine("===============================");

    Console.Write("Digite o seu número: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    int a = 0;
    int b = 1;

    Console.Write(a + " ");

    if (numero >= 1)
        Console.Write(b + " ");

    int resultado = 0;

    for (int contador = 2; ; contador++)
    {
        resultado = a + b;

        if (resultado > numero)
            break;

        Console.Write(resultado + " ");

        a = b;
        b = resultado;
    }

    Console.WriteLine();

    Console.Write("DESEJA CONTINUAR? s/N ");
    string? desejaContinuar = Console.ReadLine();

    if (desejaContinuar?.ToUpper() != "S")
        break;
}
