while (true)
{
    Console.Clear();

    Console.WriteLine("===============================");
    Console.WriteLine("Tabuada");
    Console.WriteLine("===============================");

    Console.ReadLine();

    Console.Write("Digite o numero da tabuada: ");
    int numeroTabuada = Convert.ToInt32(Console.ReadLine());

    for (int contador = 0; contador <= 10; contador++)
    {
        int resultadoTabuada = numeroTabuada * contador;

        string linhaTabuada = contador + " x " + numeroTabuada + " = " + resultadoTabuada;

        Console.WriteLine(linhaTabuada);

    }

    Console.ReadLine();
    
    Console.Write("DESEJA CONTINUAR? s/N ");
    string? desejaContinuar = Console.ReadLine();
     if (desejaContinuar?.ToUpper() != "S")
        break;

}