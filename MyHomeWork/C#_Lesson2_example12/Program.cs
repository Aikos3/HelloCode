﻿// Задача №12. 
// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
int ost = num2 % num1;

if (ost == 0) Console.WriteLine("Второе число кратно первому");
else Console.WriteLine($"Второе число не кратно первому, остаток {ost}");

