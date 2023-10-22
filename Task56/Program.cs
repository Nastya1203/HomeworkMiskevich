// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов/



int[,] GenerateRandomMatrix(int rows, int cols, int min, int max)
{
    int[,] matrix = new int[rows, cols];
    Random rand = new();

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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


int SumRowArray(int[,] matrix)
{
    int[] sumArr = new int[matrix.GetLength(0)];
    Console.WriteLine($"Сумма по строке:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumArr[i] += matrix[i, j];
        }
        Console.WriteLine($"{i + 1} -> {sumArr[i]}");
    }
    int minSum = sumArr[0];
    int minRow = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (sumArr[i] < minSum)
        {
            minSum = sumArr[i];
            minRow = i + 1;
        }
    }
    return minRow;
}

int[,] rndMatrx = GenerateRandomMatrix(3, 4, 1, 9);
PrintMatrix(rndMatrx);
int sumOfRow = SumOfRow(rndMatrx);
int[] minimumSumRow = MinimumSumRow(rndMatrx);
int sumRowArray = SumRowArray(rndMatrx);
Console.WriteLine($"Наименьшая сумма в {sumRowArray} строке. ");