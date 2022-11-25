// Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти(x и y).

Console.WriteLine("Введите номер четверти");
string Quarter = Console.ReadLine();


string Range (string Quarter1)
    {
        if (Quarter1 == "1") Console.WriteLine("x > 0, y > 0" );
        if (Quarter1 == "2") Console.WriteLine("x < 0, y < 0" );
        if (Quarter1 == "3") Console.WriteLine("x > 0, y < 0" );
        if (Quarter1 == "4") Console.WriteLine("x < 0, y > 0" );
        return "Введен некоректная четверть";
    }

string range = Range(Quarter);

Console.WriteLine(range);