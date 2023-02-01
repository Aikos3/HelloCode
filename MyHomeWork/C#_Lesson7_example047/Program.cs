// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными
// числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] myArray = new double[3, 4];
Random random = new Random();

for (int y = 0; y < myArray.GetLength(0); y++)
{
    for (int x = 0; x < myArray.GetLength(1); x++)
    {
        myArray[y, x] = Math.Round(random.NextDouble(), 2);
    }
    System.Console.WriteLine();
}

for (int y = 0; y < myArray.GetLength(0); y++)
{
    for (int x = 0; x < myArray.GetLength(1); x++)
    {
        System.Console.Write(myArray[y, x] + "\t");
    }
    System.Console.WriteLine();
}
