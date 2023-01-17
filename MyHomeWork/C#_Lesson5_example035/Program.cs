// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = GetArray(123);
Console.WriteLine($" [ {String.Join(", ", array)} ] ");

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(10, 1000);
    }

    return result;
}
int searchNumber = 0;

for (int j = 0; j < array.Length; j++)
{
    if (array[j] >= 10 && array[j] <= 99)
    {
        searchNumber += 1;
    }
}
;
Console.WriteLine("");
Console.WriteLine($"Количество элементов в диапазоне 10-99: {searchNumber}");