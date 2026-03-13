while (true)
{
    Console.Clear();

    Console.WriteLine("===============================");
    Console.WriteLine("FizzBuzz");
    Console.WriteLine("===============================");

    Console.Write("Digite o seu número: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    for (int contador = 1; contador <= numero; contador++)
    {
        if (contador % 3 == 0 && contador % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (contador % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (contador % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(contador);
        }
    }

    Console.WriteLine();

    Console.Write("DESEJA CONTINUAR? s/N ");
    string? desejaContinuar = Console.ReadLine();

    if (desejaContinuar?.ToUpper() != "S")
        break;
}
