// Задача 56:
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:
// 1 строка

Console.Clear(); // очищаем консоль, запрашиваем размеры массива

Console.Write("Укажите, сколько строк будет в массиве:");
int rows = int.Parse(Console.ReadLine());
Console.Write("Укажите, сколько столбцов будет в массиве:");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
GetRowNumber(array);
Console.WriteLine($"Строка с наименьшей суммой элементов: {GetRowNumber(array) + 1}");

int[,] GetArray(int m, int n, int min, int max) // метод, формирующий массив
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray) // метод, печатающий массив
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int GetRowNumber(int[,] array) // метод, находящий наименьшую сумму элементов в строках массива
{
    int row = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum = minSum + array[0, i];
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            row = i;
        }
    }
    return row;
}
