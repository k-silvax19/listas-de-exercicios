while (true)
{
    Console.Clear();

    Console.WriteLine("===============================");
    Console.WriteLine("Soma dos Numeros Impares");
    Console.WriteLine("===============================");

    Console.ReadLine();

    int soma = 0;

    for (int contador = 1; contador <= 500; contador++)
    {
        if (contador % 2 != 0 && contador % 3 == 0)
        {
            soma += contador;
            Console.WriteLine(contador);
        }
    }

    Console.ReadLine();

    Console.Write("DESEJA CONTINUAR? s/N ");
    string? desejaContinuar = Console.ReadLine();

    if (desejaContinuar?.ToUpper() != "S")
        break;
}