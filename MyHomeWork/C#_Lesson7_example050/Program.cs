﻿// Задача 50.
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] myArray = new int[7, 7]; // Задаём размеры массива
Random random = new Random();

// генерируем массив (заполняем значениями)
for (int y = 0; y < myArray.GetLength(0); y++) // элементы в столбцах
{
    for (int x = 0; x < myArray.GetLength(1); x++) // элементы в строках
    {
        myArray[y, x] = random.Next(-10, 11); // мин и макс значения генерируемых элементов
    }
}
Console.Clear(); // очищаем консоль

// выводим массив в консоль
for (int y = 0; y < myArray.GetLength(0); y++) // элементы в столбцах
{
    for (int x = 0; x < myArray.GetLength(1); x++) // элементы в строках
    {
        System.Console.Write(myArray[y, x] + "\t"); // выводим в консоль, добавляем знак табуляции для лучшего восприятия
    }
    System.Console.WriteLine(); // отступ вниз
}

Console.WriteLine("Введите индекс элемента массива по оси Y:"); // запрашиваем данные у пользователя
int inputY = Convert.ToInt32(Console.ReadLine()); // объявляем переменную и присваиваем ей вводимое значение с клавиатуры (предварительно, конвертировав в целочисленное значение)
Console.WriteLine("Введите индекс элемента массива по оси X:"); // запрашиваем данные у пользователя
int inputX = Convert.ToInt32(Console.ReadLine()); // объявляем переменную и присваиваем ей вводимое значение с клавиатуры (предварительно, конвертировав в целочисленное значение)

// проверяем, не выходят ли значения, указанные пользователем за размеры нашего массива
if (inputY >= myArray.GetLength(0) || inputX >= myArray.GetLength(1))
{
    System.Console.WriteLine("Элемента с данными координатами нет в массиве");
}
else
{
    Console.WriteLine("Элемент по указанным координатам -> " + myArray[inputY, inputX]);
}
