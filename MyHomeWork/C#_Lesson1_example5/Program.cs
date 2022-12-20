// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите число:");
    
int numberN = Convert.ToInt32(Console.ReadLine());
    int element = -numberN;

    while (element <= numberN) 
    {
      Console.WriteLine(element);
      element++;
    };    


