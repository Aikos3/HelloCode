//Пример 1. 
//Находим элемент в массиве с максимальным значением.

//int Max(int arg1, int arg2, int arg3)
//{
//    int result = arg1;
//     if (arg2 > result)
//         result = arg2;
//     if (arg3 > result)
//         result = arg3;
//    return result;
//}
//
//int[] array = { 1, 22, 3, 4, 5, 6, 7, 8, 9 };
//int result = Max (
//    Max (array [0], array[1], array[2]),
//    Max (array [3], array[4], array[5]),
//    Max (array [6], array[7], array[8])
//
//);
//
//Console.WriteLine(result);


//Пример 2.
// Находим в массиве индекс элемента с определённым значением (например 8).

//int[] array = { 1, 22, 8, 4, 5, 6, 7, 8, 9 };

//int n = array.Length;
//int find = 8;
//int index = 0;

//while (index < n)
// {
//  if (array [index] == find)
//       {
//          Console.WriteLine(index);
//          break; // добавляем оператор break, чтобы в случае, если в массиве присутствует несколько элементов с искомым значением, программа вывела индекс только первого найденного
//        }
//    index = index +1;
//}

//Пример 3.
//
// void FillArray (int [] collection) // Метод, заполняющий массив случайными элементами 
// {
//     int length = collection.Length;
//     int index = 0;
//         while (index < length)
//         {
//             collection [index] = new Random().Next(1, 10);
//             index++;
//         }
// }

// void PrintArray (int [] coll) // Метод, выводящий элементы массива на экран
// {   
//     int count = coll.Length;
//     int position = 0; 
//         while (position < count)
//         {
//             Console.WriteLine(coll[position]);
//             position++;
//         }
// }

// int[] array = new int [10]; // Создаем массив из 10 элементов

// FillArray(array); //Заполняем массив элементами со случайным значенем
// PrintArray(array); // Выводим на экран

//Пример 4.
//Находим индекс определёного элемента в массиве, используя метод (функцию) 

void FillArray (int [] collection) // Метод, заполняющий массив случайными элементами 
 {
     int length = collection.Length;
     int index = 0;
        while (index < length)
        {
             collection [index] = new Random().Next(1, 10);
             index++;
         }
 }

void PrintArray (int [] coll) // Метод, выводящий элементы массива на экран
{   
    int count = coll.Length;
    int position = 0; 
        while (position < count)
        {
            Console.WriteLine(coll[position]);
            position++;
        }
}

int IndexOf (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // -1 для того, чтобы в случае, когда искомого элемента не будет в массиве, мы увидели позицию -1, а не 0, как если бы искомый элемент располагался на первой позиции 
    
    while(index<count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}


int[] array = new int [10]; // Создаем массив из 10 элементов
FillArray(array); //Заполняем массив элементами со случайным значенем
PrintArray(array); // Выводим на экран
Console.WriteLine(); // выводим пустую строку, чтобы отделить элементы массива от найденного результата

int pos = IndexOf(array, 4); // пременная pos, в которую кладём результат метода IndexOf - индекс элемента со значением 4 в созданном массиве

Console.WriteLine(pos); // выводим значение pos   