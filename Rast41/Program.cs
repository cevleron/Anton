// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// int[] CreateArrayRndInt(int size, int min, int max)
// {
//    int [] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next()*10;
//     }
//     return arr;
// }

// void PrintArray(int [] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{(arr[i],2)}, ");
//         else Console.Write($"{(arr[i],1)}");
//     }
//     Console.WriteLine("]");
// }
// int[] array = CreateArrayRndInt(5, 0, 10);
// PrintArray(array);


Console.WriteLine("Введите количество элементов: ");
int numbers = Convert.ToInt32(Console.ReadLine());

int[] PrintNumbers(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите элемент {i} ----> ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int Count(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

int[] array = PrintNumbers(numbers);

Console.WriteLine($"Число элементов больше нуля ----> {Count(array)}");