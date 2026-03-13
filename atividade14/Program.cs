while (true)
{
    Console.Clear();

    Console.WriteLine("==============================");
    Console.WriteLine("Algoritmo para ler valores inteiros");
    Console.WriteLine("==============================");

    Console.Write("Digite o número 1: ");
    int numero1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o número 2: ");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o número 3: ");
    int numero3 = Convert.ToInt32(Console.ReadLine());


    if (numero1 > numero2 && numero1 > numero3)
    {
        if (numero2 > numero3)
        {
            Console.WriteLine(numero1 + " " + numero2 + " " + numero3);
        }
        else
        {
            Console.WriteLine(numero1 + " " + numero3 + " " + numero2);
        }
    }
    else if (numero2 > numero1 && numero2 > numero3)
    {
        if (numero1 > numero3)
        {
            Console.WriteLine(numero2 + " " + numero1 + " " + numero3);
        }
        else
        {
            Console.WriteLine(numero2 + " " + numero3 + " " + numero1);
        }
    }
    else
    {
        if (numero1 > numero2)
        {
            Console.WriteLine(numero3 + " " + numero1 + " " + numero2);
        }
        else
        {
            Console.WriteLine(numero3 + " " + numero2 + " " + numero1);
        }
    }

    Console.WriteLine();
    Console.Write("Deseja continuar? (S/N): ");
    string? desejaContinuar = Console.ReadLine();

    if (desejaContinuar?.ToUpper() != "S")
        break;
}