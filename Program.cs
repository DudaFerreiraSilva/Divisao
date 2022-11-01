double numerador, denominador, quociente;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("Digite o numerador......: ");
numerador = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("Digite o denominador....: ");
denominador = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();

if (denominador == 0)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Não é possível dividir por zero.");
    Console.ResetColor();
}
else
    Console.ForegroundColor = ConsoleColor.Green;
{
    quociente = numerador / denominador;

    Console.WriteLine($"{numerador:N0} dividido por {denominador:N0} é {quociente:N0}.");
}
Console.ResetColor();