// Напишите программу, которая принимает на вход координаты точки X и Y, 
// причем X не равен 0 и Y не равен 0 и выдает номер четверти в которой находится эта точка.


Console.WriteLine("Введите координаты точки");
Console.WriteLine("X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter (int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
} 
int quarter = Quarter(x,y);
string result = quarter > 0 ? $"Указанные координаты соответствуют четверти - {quarter}"
: "введены некорректные координаты";

Console.WriteLine(result);
