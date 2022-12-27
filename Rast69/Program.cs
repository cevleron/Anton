// Задача 69: Напишите программу, которая на вход принимает два числа А и В, и возводит число А в целую степень В с помощью рекурсии.
// A = 3; B = 5 -> 243 (3^5)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите натуральное число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число");
int number2 = Convert.ToInt32(Console.ReadLine());

int DegreeDigits(int num, int degree)
{
    // if (degree == 0) return 1;
    // Тернарный оператор
    return degree == 0 ? 1 : num * DegreeDigits(num, degree - 1);
}

Console.WriteLine(DegreeDigits(number1, number2));


// double Faktorial (int n)
// {
//     if (n==1) return 1;
//     else
//     return n*Faktorial(n-1);
// }
