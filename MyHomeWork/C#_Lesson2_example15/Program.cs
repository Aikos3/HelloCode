// Задача 15.
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Введите цифру от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
    if (number >= 1 && number <= 7)
        {
            if (number >= 1 && number <= 5) 
            {
                Console.WriteLine("О, это рабочий день :(");
            }
            else 
            Console.WriteLine("Ура! Это выходной день! :)");
        }
else
Console.WriteLine("Ошибка. Введите число в диапазоне от 1 до 7");
