// Решение в группах задач:
// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1,4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

void Square(int n)
{
    for (int i = 1; i < n+1; i++)
    {    Console.WriteLine($"{i} | {i*i*i}");}
}
Square(n);