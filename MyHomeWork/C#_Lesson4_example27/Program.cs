// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int result = 0;
int ostatok = number;

for (int i = 1; ostatok >= 0; i++)
{
    result = result + (number % 10);
    ostatok = (number/10);
}
;

Console.WriteLine($"Сумма цифр в числе {number} = {result}");
