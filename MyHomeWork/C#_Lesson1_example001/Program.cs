//Программа, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

//Console.WriteLine("Введите число");
//int number = Convert.ToInt32(Console.ReadLine()); //Преобразовываем введенное значение в целочисленное значение с помощью оператора Convert.ToInt32
//int square = number * number;
//Console.WriteLine("Квадрат числа "+ number + " будет " + square);

// Более сложный пример, где производится предварительная проверка числа (целое, без букв и тд.)
Console.WriteLine("Введите число");
string stringNumber = Console.ReadLine();
int number;
while (!int.TryParse (stringNumber, out number))
{
    Console.WriteLine("Ошибка! Введите целое число");
    stringNumber = Console.ReadLine().Trim();
}
int result = number * number;
Console.WriteLine($"квадрат числа {number} равен {result}"); //Добавили $ - знак интерполяции 

