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

int[] array = { 1, 22, 8, 4, 5, 6, 7, 8, 9 };

int n = array.Length;
int find = 8;
int index = 0;

while (index < n)
 {
  if (array [index] == find)
        {
          Console.WriteLine(index);
          break; // добавляем оператор break, чтобы в случае, если в массиве присутствует несколько элементов с искомым значением, программа вывела индекс только первого найденного
        }
    index = index +1;
}