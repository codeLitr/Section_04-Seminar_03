/*
Напишите программу, которая принимает на вход координаты точки (X и Y), причем X != 0 или
Y != 0 и выдает номер четверти плоскости, в которой находится эта точка.
*/

int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidateCoords(int x, int y)
{
    if (x != 0 && y != 0)
    {
        return true;
    }
    System.Console.WriteLine("Точка лежит на одной из осей");
    return false;
}

void DeterminateQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        System.Console.WriteLine("Певая четверть");
    }
    if (x < 0 && y > 0)
    {
        System.Console.WriteLine("Вторая четверть");
    }
    if (x < 0 && y < 0)
    {
        System.Console.WriteLine("Третья четверть");
    }
    if (x > 0 && y < 0)
    {
        System.Console.WriteLine("Четвертая четверть");
    }
}

int x = Promt("Введите x > ");
int y = Promt("Введите y > ");
if(ValidateCoords(x, y)) // Заменили решение ниже не функцию
//if (!(x == 0 || y == 0)) // ! обозначает отрицание. Еще варианты написания:
// if (!(x == 0) && !(y == 0))
// if (x != 0 && y != 0)
{
    DeterminateQuarter(x, y);
    // if (x > 0 && y > 0) // Данная часть убирается, т.к. добавили функцию ValidateCoords, которая заменит эту часть.
    // {
    //     System.Console.WriteLine("Певая четверть");
    // }
    // if (x < 0 && y > 0)
    // {
    //     System.Console.WriteLine("Вторая четверть");
    // }
    // if (x < 0 && y < 0)
    // {
    //     System.Console.WriteLine("Третья четверть");
    // }
    // if (x > 0 && y < 0)
    // {
    //     System.Console.WriteLine("Четвертая четверть");
    // }
}
// else // Данная часть убирается, т.к. добавили функцию ValidateCoords, которая заменит эту часть.
// {
//     System.Console.WriteLine("Точка лежит на одной из осей");
// }