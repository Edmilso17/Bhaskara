double a, b, c, delta, x1, x2;

Console.WriteLine("--equacao do segundo grau--");

Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.Write("(a): ");
a = Convert.ToDouble (Console.ReadLine());

Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.Write("(b): ");
b = Convert.ToDouble (Console.ReadLine());

Console.BackgroundColor = ConsoleColor.DarkRed;
Console.Write("(c): ");
c = Convert.ToDouble (Console.ReadLine());
Console.ResetColor();

Console.WriteLine();

if (a == 0)

{
    Console.WriteLine ("não é uma equacão de segundo grau!");
}
else
{
    delta = b * b - 4 * a * c;

    if (delta < 0)
    {
        Console.WriteLine($"como delta= {delta:n2}, a equacao nao possui raises reais!");
    }
    else
    {

    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    x2 = (-b + Math.Sqrt(delta)) / (2 * a);

    Console.WriteLine($"x1 = {x1:n2} e x2 = {x2:n2}");
    }
    }