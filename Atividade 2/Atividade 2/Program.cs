while (true)
{
    Console.Clear();

    Console.WriteLine("----------------------");
    Console.WriteLine("Calculadora de Volume Do Cilindro");
    Console.WriteLine("----------------------");

    Console.ReadLine();

    Console.Write("Digite o Raio: ");
    decimal Raio = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Digite a Altura: ");
    decimal Altura = Convert.ToDecimal(Console.ReadLine());

    decimal Pi = (decimal)Math.PI;

    decimal Base = Pi * (decimal)Math.Pow((double)Raio, 2);

    decimal resultado = Base * Altura;

    Console.WriteLine($"O resultado do volume e: {resultado:F2}");

    Console.Write("DESEJA CONTINUAR? s/N ");
    string? desejaContinuar = Console.ReadLine();

    if (desejaContinuar?.ToUpper() != "S")
        break;

}
