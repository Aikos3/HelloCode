// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = 0;
// int remains = number;

// while (number > 0)
// {
//     result = result + number % 10;
//     number /= 10;
// }
// ;
// Console.WriteLine($"Сумма цифр в числе {number} = {result}");


// Добавил метод

int GetSumNumbers(int num)
{
    int result = 0;
    int remains = num;

    while (num > 0)
    {
        result = result + num % 10;
        num /= 10;
    }
    return result;
    ;
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {number} = {GetSumNumbers(number)}");
