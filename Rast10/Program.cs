// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Вводит трехзначное число --> {number}");

int twoDigit = number / 10 % 10;

Console.WriteLine(twoDigit);