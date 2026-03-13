using System.Xml.Serialization;

while (true)
{
    Console.Clear();

    Console.WriteLine("==============================");
    Console.WriteLine("Impar Ou Par");
    Console.WriteLine("==============================");

    Console.Write("Digite o seu numero: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    Console.ReadLine();

    if (numero % 2 == 0)
    {
        Console.WriteLine("O numero e par");
    }
    else
    {
        Console.WriteLine("O numero e impar");
    }

    Console.ReadLine();


    Console.Write("DESEJA CONTINUAR? s/N ");
    string? desejaContinuar = Console.ReadLine();

    if (desejaContinuar?.ToUpper() != "S")
        break;

}