// Задача №21.
// Напишите программу, которая принимает число А и выдаёт сумму чисел от 1 до А
// 7 -> 28
// 3 -> 6

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}
;
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от 1 до {a} = {SumNumbers(a)}");
