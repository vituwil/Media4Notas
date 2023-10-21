double n1, n2, n3, n4, media;
string resultado;
ConsoleColor corresultado;

Console.WriteLine("      Média\n");
Console.WriteLine("Digite suas notas:");

Console.WriteLine("Nota 1:");
n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Nota 2:");
n2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Nota 3:");
n3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Nota 4:");
n4 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

if (n1 < 0 || n1 > 10 
 || n2 < 0 || n2 > 10
 || n3 < 0 || n3 > 10
 || n4 < 0 || n4 > 10)
{
    Console.WriteLine("Digite somente notas entre 0 e 10.");  
}
else
{
    media = (n1 + n2 + n3 + n4) / 4;
    
    if (media < 5)
    {
        corresultado = ConsoleColor.Red;
        resultado = "REPROVADO";
    }
    else if (media > 6)
    {
        corresultado = ConsoleColor.Green;
        resultado = "APROVADO";
    }
    else
    {
        corresultado = ConsoleColor.Yellow;
        resultado = "RECUPERAÇÃO";
    }

    Console.Write($"Sua média é {media:n1}. Resultado: ");
    Console.ForegroundColor = corresultado;
    Console.WriteLine($"{resultado}.");
    Console.ResetColor();
}
