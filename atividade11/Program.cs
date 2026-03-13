while (true)
{
    Console.Clear();

    Console.WriteLine("==============================");
    Console.WriteLine("Calculadora de Volume de Anos de Vida");
    Console.WriteLine("==============================");

    Console.ReadLine();

    Console.Write("Digite o seu nome: ");
    string? nome = (Console.ReadLine());

    Console.Write("Digite o seus anos de vida: ");
    decimal anosVida = Convert.ToDecimal(Console.ReadLine());

    decimal resultado = anosVida * 365;

    Console.WriteLine($"olá {nome} seus anos de vida são: {resultado}");
    Console.ReadLine();

    Console.Write("DESEJA CONTINUAR? s/N ");
    string? desejaContinuar = Console.ReadLine();

    if (desejaContinuar?.ToUpper() != "S")
        break;
}
