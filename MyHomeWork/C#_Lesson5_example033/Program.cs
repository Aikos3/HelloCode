// Задача 33:
//Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите число от 1 до 9");
int findNumber = Convert.ToInt32(Console.ReadLine());

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
bool numberExist = false;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == findNumber)
    {
        numberExist = true;
    }
}

if (numberExist == true) Console.WriteLine($"Массив содержит число {findNumber}");
else {
    Console.WriteLine($"Массив не содержит число {findNumber}");
}
