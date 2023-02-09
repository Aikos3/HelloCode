// Задача 58:
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear(); // очищаем консоль, запрашиваем размеры массива

Console.Write("Укажите, сколько строк будет в первом массиве:");
int rowsA = int.Parse(Console.ReadLine());
Console.Write("Укажите, сколько столбцов будет в первом массиве:");
int columnsA = int.Parse(Console.ReadLine());
Console.Write("Укажите, сколько строк будет во втором массиве:");
int rowsB = int.Parse(Console.ReadLine());
Console.Write("Укажите, сколько столбцов будет во втором массиве:");
int columnsB = int.Parse(Console.ReadLine());

if (columnsA != rowsB)
{
    Console.WriteLine("Такие марицы умножать нельзя!");
    return;
}

int[,] A = GetArray(rowsA, columnsA, 0, 10);
int[,] B = GetArray(rowsB, columnsB, 0, 10);
PrintArray(A);
Console.WriteLine();
PrintArray(B);
Console.WriteLine();
PrintArray(GetMultiplicationMatrix(A, B));

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

int[,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int row = 0; row < arrayA.GetLength(0); row++)
    {
        for (int column = 0; column < arrayB.GetLength(1); column++)
        {
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayC[row, column] += arrayA[row, k] = arrayB[k, column];
            }
        }
    }
    return arrayC;
}
