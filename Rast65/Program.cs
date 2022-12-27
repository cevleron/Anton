// Задача 65: Задайте значения М и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от М до N.
// M = 1; N = 5-> "1, 2, 3,4, 5"
// M=4; N = 8-> "4, 6, 7,8"

Console.WriteLine("Введите натрульное число");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натрульное число");
int N = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(M, N);

void NaturalNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        // Console.Write($"{num2} ");
        NaturalNumbers(num1, num2 + 1);
        Console.Write($"{num2} ");
    }
    if (num1 < num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 + 1, num2);
    }
    if (num1 == num2) Console.Write($"{num1} ");

}
