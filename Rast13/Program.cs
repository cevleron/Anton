// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число до 3-х символов включительно");
long number = Convert.ToInt32(Console.ReadLine());


while (number > 999)
{
    number /= 10;
}
Console.WriteLine(number);

long result = number%10;
Console.WriteLine(result);
// if (number < 999) Console.WriteLine("Третьей цифры нет");

// while (number < 99) Console.WriteLine("Третьей цифры нет");
