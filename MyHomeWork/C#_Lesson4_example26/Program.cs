// Задача 26: Напишите программу, которая принимает на вход число и выдаёт
// количество цифр в числе.

int GetDigitCount(int num)
{
int digitCount = 1;
while (num >= 10)
{
    num = num / 10;
    digitCount++;
}
return digitCount;
}
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"В данном числе {GetDigitCount(number)} цифр");
