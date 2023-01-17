// Задача 13.
// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int numAbs = Math.Abs(num);
if (numAbs < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (numAbs > 999)
    {
        numAbs /= 10;
    }
    int result = numAbs %= 10;

    Console.WriteLine($"третья цифра в числе {num} -> {result}");
}
;
