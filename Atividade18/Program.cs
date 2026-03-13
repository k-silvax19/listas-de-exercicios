using System;

while (true)
{
    Console.Clear();

    Console.WriteLine("===============================");
    Console.WriteLine("Mostrar os números ímpares entre 100 e 200");
    Console.WriteLine("===============================");

    Console.ReadLine();

    for (int contador = 100; contador <= 200; contador++)
    {
        if (contador % 2 != 0)
        {
            Console.WriteLine(contador);
        }
    }

    Console.ReadLine();

    Console.Write("DESEJA CONTINUAR? s/N ");
    string? desejaContinuar = Console.ReadLine();

    if (desejaContinuar?.ToUpper() != "S")
        break;
}