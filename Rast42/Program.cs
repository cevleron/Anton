// Напишите программу которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// Console.WriteLine("Введите число которое нужно перевести в двоичное исчисление");
// int x = Convert.ToInt32(Console.ReadLine());
// string Binary (int number)
// {
//     string bin = string.Empty;
//     while (number > 0)
//     {
//         bin = number % 2 + bin;
//         number /= 2;
//     }
//     return bin;

// }
// Console.WriteLine(Binary(x));

void PrintArray(int[] arr, string beginstr, string separatortElems, string endstr)
{
    Console.Write(beginstr);
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}{separatortElems}");
            else Console.Write ($"{arr[i]}");
    }
    Console.Write(endstr);
}



int[] Binary(int numb)
{
    int numb1 = numb;
    int digits = 0;
    while (numb1 > 0)
    {
        numb1 /= 2;
        digits += 1;
    }
    int[] bin = new int[digits];
    for (int i = 0; i < bin.Length; i++)
    {
        bin[bin.Length-i-1] = numb % 2;
        numb /= 2;
    }

    return bin;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] binary = Binary(number);
// Array. Reverse (binary);
// Console.writeLine(Binary (number)) ;
PrintArray(binary, "", "", "");