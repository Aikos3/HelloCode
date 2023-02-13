// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше либо равна 3 символа.

Console.WriteLine("Введите через пробел несколько слов разной длины:");
string inputString = Console.ReadLine();
string[] arrayOriginal = inputString.Split(' ');

string[] arrayNew = new string[arrayOriginal.Length];

FindElement(arrayOriginal, arrayNew);
Console.Write($"Длина вот этих элементов меньше или равна 3 символа --> ");
PrintArray(arrayNew);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void FindElement(string[] arrayInput, string[] arrayOutput)
{
    int count = 0;
    for (int i = 0; i < arrayInput.Length; i++)
    {
        if (arrayInput[i].Length <= 3)
        {
            arrayOutput[count] = arrayInput[i];
            count++;
        }
    }
}
