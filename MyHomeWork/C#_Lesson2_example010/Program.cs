// Задача 10. Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");

//int num = new Random().Next(100, 1000);
int num = Convert.ToInt32(Console.ReadLine());
int secondNumber = num / 10 % 10;
Console.WriteLine($"Вторая цифра в числе {num} -> {secondNumber}");
