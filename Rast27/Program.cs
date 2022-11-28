// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

// while (number < 0 )
// {
//     Console.WriteLine("Введите число");
//     number = Convert.ToInt32(Console.ReadLine());
//     if (number < 0) Console.WriteLine("Введите введите целое положительное число");
// }

int num = 0;
while (number > 0)
{
    num = num + number%10;
    number = number/10;
    
}
Console.WriteLine(num);