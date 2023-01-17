// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа

int number;
int result;

Console.WriteLine("Введите трёхзначное число:");
number = Convert.ToInt32(Console.ReadLine());

result = (number % 10);
Console.WriteLine($"Последней цифрой введенного числа, является {result} ");
