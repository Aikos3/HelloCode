// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = GetArray(10);
Console.WriteLine($" [ {String.Join(", ", array)} ] ");

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 10);
    }
    return result;
}

int sumElement = 0;

for (int count = 1; count < array.Length; count = count + 2)
{
    sumElement += array[count];
}

Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sumElement}");
