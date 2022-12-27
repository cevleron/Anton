// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

// Метод по созданию двумерного массива.
int[,] CreateMatrixRndInt2(int rows, int columns, int min, int max)
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

int[,] matrix = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
int[,] matrix2 = CreateMatrixRndInt2(2, 2, 1, 9);
PrintMatrix(matrix2);

int[,] GenerationMassiv(int[,] matrix, int[,] matrix2)
{
    if (matrix.GetLength != matrix2.GetLength)
       { Console.WriteLine("Умножать матрицы нельзя так как они не соответствуют правилам умножения");}
        int[,] matrix3 = new int[matrix.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix3[i, j] += matrix[i, k] * matrix2[k, j];
                }
            }
        }
        return matrix3;
    
}

int[,] generationMassiv = GenerationMassiv(matrix, matrix2);
PrintMatrix(generationMassiv);