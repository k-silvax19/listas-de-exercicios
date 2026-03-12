while (true)
{
    Console.Clear();

    Console.WriteLine("========================================");
    Console.WriteLine("Calculadora de Salario");
    Console.WriteLine("========================================");

    Console.ReadLine();

    Console.Write("Salario Base: ");
    decimal Salario = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Total De Vendas: ");
    decimal Vendas = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Digite o valor da comissão (porcentagem): ");
    decimal comissao = Convert.ToDecimal(Console.ReadLine());

    decimal salariototal = Salario + (Vendas * (comissao / 100));

    Console.ReadLine();

    Console.WriteLine($"o salario total e:  {salariototal}");

    Console.ReadLine();

    Console.Write("DESEJA CONTINUAR? s/N ");
    string? desejaContinuar = Console.ReadLine();

    if (desejaContinuar?.ToUpper() != "S")
        break;

}