Console.WriteLine("Введите первое число");
int a = ConvertToConsole.Read();
Console.WriteLine("Введите второе число");
int b = Console.Read();
if (a == b * b)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
