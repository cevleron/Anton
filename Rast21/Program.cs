// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты X1 первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y1 первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y2 первой точки");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты X2 второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y2 первой точки");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y2 первой точки");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double a = (x1-x2)*(x1-x2);
    double b = (y1-y2)*(y1-y2);
    double c = (z1-z2)*(z1-z2);
    double result = Math.Sqrt(a+b+c);
    return result;
}
double res = Distance(x1,y1,z1,x2,y2,z2);
double result = Math.Round(res,2,MidpointRounding.ToZero);
Console.WriteLine(result);