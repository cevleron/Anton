﻿// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]



// Console.WriteLine("Введите количество элементов массива");
// int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[8];

void RandomArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0,2);

        
    }
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}
RandomArray(array);
PrintArray(array);