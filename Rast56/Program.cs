// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



// Метод по созданию двумерного массива.
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

// Метод печатающий двумерный массив.
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2}, ");
            else Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine("]");
    }
}

int[,] matrix = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(matrix);



// Часть по суммированию элементов в строке массива
int[] SumRowMatrix(int[,] matrix)
{
    int sum = 0;
    int[]matrix2 = new int [matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           sum +=matrix[i,j];
           matrix2[i] = sum;
        }
        sum = 0;
    }
    return matrix2;
}
//  Вывод результата сумирования элементов в виде одномерного массива
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

Console.WriteLine();

int[] SumRow = SumRowMatrix(matrix);
PrintArray(SumRow);

// void ResultSmallRow(int[]matrix)
// for (int i = 0; i < matrix.Length; i++)
// {
//     if (matrix[i]<sum)
//     {
        
//     }
// }

int ResultSmallRow(int[] array)
{
    int resultSumma = array[0];
    int resultRow = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < resultSumma)
        {
            resultSumma = array[i];
            resultRow = i;
        }
    }
    return (resultRow);
}

int rezultSmallRow = ResultSmallRow(SumRow);
Console.WriteLine($"Минимальная сумма в строке -> {rezultSmallRow+1}");