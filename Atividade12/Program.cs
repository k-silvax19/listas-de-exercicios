while (true)
{
    Console.Clear();

    Console.WriteLine("==============================");
    Console.WriteLine("algoritmo para ler o salário de um funcionário");
    Console.WriteLine("==============================");

    Console.ReadLine();

    Console.Write("Digite o Salario inicial: ");
    decimal salarioInicial = Convert.ToDecimal(Console.ReadLine());

    decimal salarioComAumento = salarioInicial * 1.15m;
    decimal salarioFinal = salarioComAumento * 0.92m;

    Console.WriteLine($"Salário inicial: {salarioInicial:C}");
    Console.WriteLine($"Salário com aumento: {salarioComAumento:C}");
    Console.WriteLine($"Salário final após imposto: {salarioFinal:C}");

    Console.ReadLine();

    Console.Write("DESEJA CONTINUAR? s/N ");
    string? desejaContinuar = Console.ReadLine();

    if (desejaContinuar?.ToUpper() != "S")
        break;
}
