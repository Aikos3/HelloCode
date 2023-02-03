// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественным числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] myArray = new double[3, 4]; // объявляем массив и задаем размеры
Random random = new Random();
double minValue = -10; // минимальное значение элемента в массиве
double maxValue = 10; // максимальное начение элемента в массиве

// заполняем массив значениями 
for (int y = 0; y < myArray.GetLength(0); y++) 
{
    for (int x = 0; x < myArray.GetLength(1); x++) 
    {
        myArray[y, x] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2); // используем формулу, чтобы получить числа дробные числа в заданном выше диапазоне от мин до макс
    }
    System.Console.WriteLine();
}
// выводим массив в консоль
for (int y = 0; y < myArray.GetLength(0); y++)
{
    for (int x = 0; x < myArray.GetLength(1); x++)
    {
        System.Console.Write(myArray[y, x] + "\t");
    }
    System.Console.WriteLine();
}
