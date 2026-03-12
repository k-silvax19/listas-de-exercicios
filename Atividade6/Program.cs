while (true)
{
    Console.Clear();

    Console.WriteLine("===============================");
    Console.WriteLine("Calculadora de nota media harmonica");
    Console.WriteLine("===============================");

    Console.ReadLine();

    int QuantidadeDeNotas = 0;
    decimal mediaHarmonica = 0;
    decimal notaDigitada = 0;
    decimal somaInverso = 0;

    Console.Write("Quantas notas o aluno tem: ");
    QuantidadeDeNotas = Convert.ToInt32(Console.ReadLine());

    decimal[] notasAlunos = new decimal[QuantidadeDeNotas];

    for (int contador = 0; contador < QuantidadeDeNotas; contador++)
    {
        Console.Clear();

        Console.Write($"Digite a nota {contador + 1} do aluno: ");
        notaDigitada = Convert.ToDecimal(Console.ReadLine());

        if (notaDigitada == 0)
        {
            Console.WriteLine("Nota não pode ser 0 na média harmônica!");
            contador--;
            Console.ReadLine();
            continue;
        }

        notasAlunos[contador] = notaDigitada;

        somaInverso += 1 / notaDigitada;
    }


    mediaHarmonica = QuantidadeDeNotas / somaInverso;

    Console.WriteLine($"A média harmônica é: {mediaHarmonica:F2}");

    Console.ReadLine();

    Console.Write("DESEJA CONTINUAR? s/N ");
    string? desejaContinuar = Console.ReadLine();

    if (desejaContinuar?.ToUpper() != "S")
        break;
}