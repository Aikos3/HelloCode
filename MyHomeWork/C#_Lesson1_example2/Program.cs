﻿//Задача 2.
//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
    if (firstNumber > secondNumber)
        {
        Console.WriteLine($"Первое число: {firstNumber} больше, чем второе число: {secondNumber}");
        }
    else 
        {
        Console.WriteLine($"Второе число: {secondNumber} больше, чем первое число: {firstNumber}");
        }