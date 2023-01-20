// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементом массива.

//Пример решения с массивом из простых чисел

// Console.Clear();
// int[] array = GetArray(10);
// Console.WriteLine($" [ {String.Join(", ", array)} ] ");

// int[] GetArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(-99, 100);
//     }

//     return result;
// }
// int maxElement = -99;
// int minElement = 99;
// int result = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > maxElement)
//         maxElement = array[i];
// }
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] < minElement)
//         minElement = array[i];
// }
// result = maxElement - minElement;

// Console.WriteLine($"Максимальное значение элемента: {maxElement}, минимальное значение элемента: {minElement}");
// Console.WriteLine($"Разница между максимальным и минимальным значением: {result}");


//Пример решения с массивом из вещественных чисел

Console.Clear();
double[] array = GetArray(10, -99, 99);
Console.WriteLine($" [ {String.Join(" ", array)} ] ");

double[] GetArray(int size, int min, int max)
{
    double[] result = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
        result[i] = Math.Round(rnd.NextDouble() + rnd.Next(min, max), 2);

    return result;
}

double maxElement = array[0];
double minElement = array[0];
double result = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > maxElement)
        maxElement = array[i];
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < minElement)
        minElement = array[i];
}
result = maxElement - minElement;

Console.WriteLine(
    $"Максимальное значение элемента: {maxElement}, минимальное значение элемента: {minElement}"
);
Console.WriteLine($"Разница между максимальным и минимальным значением: {result}");
