﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите первое число:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Второе число:");
// int b = Convert.ToInt32(Console.ReadLine());
// int result = a;
// for (int i = 1; i < b; i++)
// {
//     result = result * a;
// }
// Console.WriteLine($"{a} в степени {b} = {result}");


//ниже добавил функцию


int GetDegree(int num1, int num2)
{
    int result = num1;
    for (int i = 1; i < num2; i++)
    {
        result = result * num1;
    }
    return result;
}

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Второе число:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} в степени {b} = {GetDegree(a, b)}");
