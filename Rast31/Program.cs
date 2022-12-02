﻿// Задача 31: 
// 1.Задайте массив из 12 элементов, 
// 2.заполненный случайными числами из промежутка [-9, 9]. 
// Вывести массив в консоль.
// 4.Найдите сумму "отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateArrayRndInt (int size, int min, int max)
{
    int [] arr = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min,max+1);
    }
    return arr;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int GetSumNegativeElem (int[] arr)
{
    int sumNegative = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0 ) sumNegative += arr[i];
    }
    return sumNegative;
}

int GetSumPositiveElem (int[] arr)
{
    int sumPositive = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0 ) sumPositive += arr[i];
    }
    return sumPositive;
}

int [] array = CreateArrayRndInt(12,-9,9);
PrintArray(array);
 
int sumNegative = GetSumNegativeElem(array);
int sumPositive = GetSumPositiveElem(array);
Console.WriteLine($"Сумма положительных чисел = {sumPositive}, сумма отрицательных чисел = {sumNegative}");