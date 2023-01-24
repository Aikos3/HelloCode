// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования

int[] arr = CreateRandomArray(10, 10, 100);
Console.WriteLine($" Исходный массив: [{String.Join(", ", arr)}]");
int[] array = CopyArray(arr);
Console.WriteLine($" Скопированный массив: [{String.Join(", ", array)}]");

int[] CopyArray(int[] array)
{
    int[] copArr = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copArr[i] = array[i];
    }
    return copArr;
}

int[] CreateRandomArray(int size, int start, int end)
{
int[] RandomArray = new int[size];
Random random = new Random();
for (int i = 0; i < size; i++)
{
    RandomArray[i] = random.Next(start, end);
}
return RandomArray;
}