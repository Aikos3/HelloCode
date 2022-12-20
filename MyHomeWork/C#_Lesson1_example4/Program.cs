//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int maxNum = firstNumber;
if (secondNumber > maxNum) maxNum = secondNumber;
if (thirdNumber > maxNum) maxNum = thirdNumber;
    
Console.WriteLine($"Максимальное из трёх чисел: {maxNum}");