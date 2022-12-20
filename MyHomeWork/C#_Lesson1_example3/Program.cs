//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница

string[] array = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
int inputNumber;

Console.WriteLine("Введите число от 1 до 7");
inputNumber = Convert.ToInt32(Console.ReadLine());
    if (inputNumber > 7)
        {
          Console.WriteLine("Ошибка! Введите число от 1 до 7");
        }
    else
Console.WriteLine (array[inputNumber - 1]);