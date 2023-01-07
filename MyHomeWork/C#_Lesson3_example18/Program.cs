// Задача № 18
// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());

switch (quarter)
{
    case 1:

        {
            Console.WriteLine("Диапазон возможных координат точек в этой четверти: x > 0, y > 0");
            break;
        }
        ;
    case 2:

        {
            Console.WriteLine("Диапазон возможных координат точек в этой четверти: x < 0, y > 0");
            break;
        }
        ;
    case 3:

        {
            Console.WriteLine("Диапазон возможных координат точек в этой четверти: x < 0, y < 0");
            break;
        }
        ;
    case 4:

        {
            Console.WriteLine("Диапазон возможных координат точек в этой четверти: x > 0, y < 0");
            break;
        }
        ;

    default:

        {
            Console.WriteLine("Введите корректный номер четверти");
            break;
        }
        ;
}
;
