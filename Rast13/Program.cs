// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет 
// 32679 -> 6
Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
string num = Convert.ToString(number);

if (num.Length > 2) 
{
    Console.WriteLine($"Третья цифры --> {num[2]}");
} 
else
{
    Console.WriteLine("Третьей цифры нет");
}
