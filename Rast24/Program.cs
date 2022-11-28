// Демонстрация решения
// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до A.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число от 1 до A");
int A = Convert.ToInt32(Console.ReadLine());

int sumDigits(int a)
{
    int sum = 0;
        for (int i = 0; i <= a; i++)
        {
           sum = sum + i;

        }
    return sum;
}

if(A > 0 )
{
    int SumDigits = sumDigits(A);
    Console.WriteLine($"{A} -> {SumDigits}");
}
else Console.WriteLine("Требуется ввести натуральное число");