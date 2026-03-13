using System.Xml.Serialization;

while (true)
{
    Console.Clear();

    Console.WriteLine("==============================");
    Console.WriteLine("Calculadora De IMC");
    Console.WriteLine("==============================");

    Console.Write("Digite o Peso: ");
    decimal peso = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Digite a Altura ");
    decimal altura = Convert.ToDecimal(Console.ReadLine());

    decimal altura2 = altura * altura;

    decimal imc = peso / altura2;

    Console.ReadLine();

    if (imc < 18.5m)
    {
        Console.WriteLine("Voce esta abaixo peso");
    }
    else if (imc < 25)
    {
        Console.WriteLine("voce esta com o peso normal");
    }
    else if (imc < 30)
    {
        Console.WriteLine("Voce esta acima peso");
    }
    else
    {
        Console.WriteLine("Voce esta Obeso");
    }

    Console.ReadLine();

    Console.Write("DESEJA CONTINUAR? s/N ");
    string? desejaContinuar = Console.ReadLine();

    if (desejaContinuar?.ToUpper() != "S")
        break;

}