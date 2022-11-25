// Напишите программу которая на вход принимает координаты двух точек и находит расстояние
// между ними в 2D пространстве.
// A(3,6)B(2,1) -> 5.09
// A(7,-5)B(1,-1) ->7.21

Console.WriteLine("Введите координаты X1 первой точки");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y1 первой точки");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты X2 второй точки");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y2 первой точки");
double y2 = Convert.ToInt32(Console.ReadLine());

double x = x1-x2;
double A = Math.Pow(x,2);
Console.WriteLine(x);
double y = y1-y2;
double B = Math.Pow(y,2);
Console.WriteLine(y);

double z = Math.Sqrt(A+B);
Console.WriteLine(z);