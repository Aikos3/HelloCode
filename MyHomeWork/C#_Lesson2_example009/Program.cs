// Напишите программу, которая выводит случайное число из отрезка 10 - 99,
// и показывает наибольшую цифру числа
// Например: 78 -> 8, 12 -> 2 ...

int number = new Random().Next(10, 100); // генерируем число от 10 до 99 (крайнее число 100 не включается)
Console.WriteLine(number);

if (number / 10 > number % 10)
    Console.WriteLine(number / 10);
else
    Console.WriteLine(number % 10);
