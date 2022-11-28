// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

while (number <= 0)
{
    Console.WriteLine("Введите число: ");
    number = Convert.ToInt32(Console.ReadLine());

    if (number < 0) Console.WriteLine("Введены неверные данные");
}

int MultDigits(int num)
{
    int mult = 1;

    for (int i = 1; i <= num; i++)

        { 
            mult = mult * i;
        }
return mult;
}   
int multDigits = MultDigits(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {multDigits}");