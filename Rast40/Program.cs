// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool Triagnle(int al, int b1, int c1)
{
return al < b1+c1 && b1 < al+c1 && c1 < al+b1;
}


Console.WriteLine("Введите первую сторону треугольника") ;
int a = Convert. ToInt32(Console. ReadLine());
Console.WriteLine("введите вторую сторону треугольника");
int b = Convert. ToInt32(Console. ReadLine ());
Console.WriteLine("Введите третью сторону треугольника");
int c = Convert. ToInt32(Console. ReadLine());
Console.WriteLine(Triagnle(a,b,c)?"Треугольник может существовать": "Треугольник не может существовать");