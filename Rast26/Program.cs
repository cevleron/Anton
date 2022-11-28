// Решение в группах задач:
// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int Amount (int num)
{
    int i = 0;

    while ( num > 0)
    {
       
        num = num / 10;
        i++;
    }
    return i;
}

if (number > 0)
{
    int amount = Amount(number);
    Console.WriteLine($"{number} -> {amount}");
}
else Console.WriteLine("Введите корректное число");

// Дополнительное решение данной задач.

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int Digits (int num)

//     {int count = 0;
//         while (num > 0)
//         {
//             num = num / 10;
//             count++;

//         }
//     return count == 0? 1 : count;
//     }
// if (number < 0) number = -number;
// int result = Digits (number);
// Console.WriteLine($"Количество цифр в числе {number} ---> {result}");