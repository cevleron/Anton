// Напишите программу которая на вход принимает координаты двух точек и находит расстояние
// между ними в 2D пространстве.
// A(3,6)B(2,1) -> 5.09
// A(7,-5)B(1,-1) ->7.21

Console.WriteLine("Введите координаты X1 первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y1 первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты X2 второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y2 первой точки");
int y2 = Convert.ToInt32(Console.ReadLine());

// double x = x1-x2;
// double A = Math.Pow(x,2);
// Console.WriteLine(x);
// double y = y1-y2;
// double B = Math.Pow(y,2);
// Console.WriteLine(y);

// double z = Math.Sqrt(A+B);
// double result = Math.Round(z,2,MidpointRounding.ToZero);
// Console.WriteLine(result);

// Второй вариант кода

double Distance (int x1, int y1, int x2, int y2)
{
    double a = (x1-x2)*(x1-x2);
    double b = (y1-y2)*(y1-y2);
    double result = Math.Sqrt(a+b);
    return result;
}
double res = Distance(x1,y1,x2,y2);
double result = Math.Round(res,2,MidpointRounding.ToZero);
Console.WriteLine(result);