﻿// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов вкаждом столбце.

// Например:
// 1 4 7 2
//  5 9 2 3
//  8 4 2 4

//  среднее ариф-ое каждого столбца: 4,6; 5,6; 3,6; 3



int[,] GenerateRandomMatrix(int rows, int cols, int min, int max)
{
    int[,] matrix = new int[rows, cols];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(min, max);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|   ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine("|");
    }
}

void Arif(int[,] matrix)
{
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i,j];
        }
        Console.Write($"{sum / matrix.GetLength(0)}   ");
    }
}


int[,] rndMatrx = GenerateRandomMatrix(4, 5, 0, 10);
PrintMatrix(rndMatrx);
Arif(rndMatrx);