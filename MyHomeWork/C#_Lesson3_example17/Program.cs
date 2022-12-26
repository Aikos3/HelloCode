// Задача № 17. 
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координату X:");
int xPoint = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y:");
int yPoint = Convert.ToInt32(Console.ReadLine());

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
Console.WriteLine("Точка находится во 2-й четверти");
};