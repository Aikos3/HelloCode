// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементом массива.

// double[] array = new double[10];
// Console.WriteLine($" [ {String.Join(", ", array)} ] ");

// double[] GetArray(float size)
// {
//     double[] result = new double[size];
//     for (float  i = 0; i < size; i++)
//     {
//         result[i] = new Random().NextDouble(1.0, 10.0f);
//     }
//     return result;
// }

Console.Clear();
int[] array = GetArray(10);
Console.WriteLine($" [ {String.Join(", ", array)} ] ");

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-99, 100);
    }

    return result;
}
int maxElement = -99;
int minElement = 99;
int result = 0;

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

Console.WriteLine($"Максимальное значение элемента: {maxElement}, минимальное значение элемента: {minElement}");
Console.WriteLine($"Разница между максимальным и минимальным значением: {result}");
