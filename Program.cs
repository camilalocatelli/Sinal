int numero;
Console.Write("Digite um número: ");
numero = Convert.ToInt32 (Console.ReadLine());

if (numero < 0)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Negativo!");
}
else if (numero > 0)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Positivo!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Zero!");
}

Console.ResetColor();