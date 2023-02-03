// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] myArray = new int[5, 5];
Random random = new Random();
double sumElement = 0;

for (int y = 0; y < myArray.GetLength(0); y++)
{
    for (int x = 0; x < myArray.GetLength(1); x++)
    {
        myArray[y, x] = random.Next(0, 10);
    }
}

for (int y = 0; y < myArray.GetLength(0); y++)
{
    for (int x = 0; x < myArray.GetLength(1); x++)
    {
        System.Console.Write(myArray[y, x] + "\t");
    }
    System.Console.WriteLine();
}

for (int x = 0; x < myArray.GetLength(1); x++)
{
    for (int y = 0; y < myArray.GetLength(0); y++)
    {
        sumElement += (myArray[y, x]);
    }
    Console.WriteLine($"Среднее арифметическое элементов {x + 1} столбца: {Math.Round(sumElement / myArray.GetLength(0), 2)}");
}