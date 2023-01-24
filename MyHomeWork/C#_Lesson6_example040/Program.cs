// Задача 40:
// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.
// (Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух
// других сторон.)

// Console.WriteLine("Введите через пробел три числа, соответствующих длинам сторон треугольника");

// int[] array = GetArray(3);
// Console.WriteLine($" [ {String.Join(", ", array)} ] ");

// int[] GetArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(0, 10);
//     }

//     return result;
// }
// int maxSide = array[0];
// for (int i = 1; i < array.Length; i++)
// {
//     if (array[i] > maxSide)
//     {
//         maxSide = array[i];
//     }
// }

// Console.WriteLine($"Максимальная сторона {maxSide}");


int[] array = CreateArray(3);
Console.WriteLine($"{CheckArray(array)}");


int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = EnterNumber($"Введите длину {i + 1} стороны");
    }
    return array;
}



bool CheckArray(int[] array)
{
int max = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > array[max])
        max = i;
}

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i != max)
        sum += array[i];
}
return (array[max] < sum ? true : false);
}


int EnterNumber(string str)
{
    Console.WriteLine(str);
    string stringNumber = Console.ReadLine()!.Trim();
    int number;
    while (!int.TryParse(stringNumber, out number))
    {
        Console.WriteLine($"Ошибка! {str}");
        stringNumber = Console.ReadLine()!.Trim();
    }
    return number;
}
