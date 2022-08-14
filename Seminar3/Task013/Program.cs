// Решения задач.
// Задача 1.
// Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
// выдаёт номер четверти плоскости, в которой находится эта точка и
// показывает диапазон возможных координат точек в этой четверти (x и y).
// A (2, 3) -> 1 четверть, x > 0, y > 0
// A (-5, -8) -> 3 четверть, x < 0, y < 0
double determinationOfQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x > 0 && y < 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    if (x < 0 && y > 0)
    {
        return 4;
    }
    return 0;
}

Console.WriteLine("Введите кординаты точки A: x и y");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

Console.WriteLine($"Точка лежит в {determinationOfQuarter(x, y)} четвери");


// Задача 2.
// Напишите программу, которая принимает на вход координаты двух точек и
//находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double calcDistance(int ax, int ay, int bx, int by)
{
    return Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
}

Console.WriteLine("Введите кординаты точки А: x и y");
int ax = int.Parse(Console.ReadLine());
int ay = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кординаты точки B: x и y");
int bx = int.Parse(Console.ReadLine());
int by = int.Parse(Console.ReadLine());

Console.WriteLine($"Растояние между точками равно {calcDistance(ax, ay, bx, by)}");
