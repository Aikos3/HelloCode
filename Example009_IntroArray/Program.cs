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

int[] array = { 1, 22, 3, 4, 5, 6, 7, 8, 9 };

int n = array.Length;
int find = 8;
int index = 0;

while (index < n)
 {
  if (array [index] == find)
        {
          Console.WriteLine(index);
        }
    index = index +1;
}