// Задача № 17. 
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void Show (int xPoint, int yPoint)
{
if (xPoint == 0 || yPoint == 0){
Console.WriteLine("Невозможно определить четверть");
}
else if (xPoint > 0 && yPoint > 0) {
Console.WriteLine("Точка находится в 1-й четверти");
}
else if (xPoint < 0 && yPoint > 0){
Console.WriteLine("Точка находится во 2-й четверти");
}
else if (xPoint < 0 && yPoint < 0){
Console.WriteLine("Точка находится во 3-й четверти");
}
else if (xPoint > 0 && yPoint < 0){
Console.WriteLine("Точка находится во 4-й четверти");
};
};

Console.WriteLine("Введите координату X:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y:");
int y = Convert.ToInt32(Console.ReadLine());

Show (5,12);
Show (x, y);