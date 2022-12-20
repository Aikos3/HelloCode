// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

int number;

Console.WriteLine ("Введите число:");
number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Данное число делится на 2 без остатка и является чётным"); 
}
else
Console.WriteLine("Данное число нечётное");