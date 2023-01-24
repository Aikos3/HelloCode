// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int number = EnterNumber("Введите целое число");
int[] array = Fibonacci(number);
Console.WriteLine($"[{String.Join(", ", array)}]");

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

int[] Fibonacci(int size)
{
    int[] array = new int[size];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < size; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}
