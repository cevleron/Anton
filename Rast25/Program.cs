// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень числа А");
int B = Convert.ToInt32(Console.ReadLine());

double Pow (int a, int b)
{
    
    double sqr = Math.Pow(a,b);
    return sqr;
}

double pow = Pow(A,B);
Console.WriteLine($"{A}, {B} -> {pow}");