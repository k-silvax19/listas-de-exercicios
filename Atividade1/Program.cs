while (true)
{
    Console.Clear();

    Console.WriteLine("==============================");
    Console.WriteLine("Calculadora de Volume de Caixa Retangular");
    Console.WriteLine("==============================");

    Console.ReadLine();

    Console.Write("Digite o comprimento da caixa: ");
    decimal comprimento = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Digite a largura da caixa: ");
    decimal largura = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Digite a altura da caixa: ");
    decimal altura = Convert.ToDecimal(Console.ReadLine());

    decimal resultado = comprimento * largura * altura;

    Console.WriteLine($" o resultado e: {resultado}");

    Console.Write("DESEJA CONTINUAR? s/N ");
    string? desejaContinuar = Console.ReadLine();

    if (desejaContinuar?.ToUpper() != "S")
        break;
}
