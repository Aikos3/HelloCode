

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine($"Третьей цифры нет");
    return;
}
int thirdNumber = (num / 100) % 10;
Console.WriteLine($"Третья цифра числа {num} -> {thirdNumber}");
