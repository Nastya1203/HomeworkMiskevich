// Задача 47: Задайте двумерный массим размеров m x n,
// заполенный случайными вещественными числами.
// m = 3, n = 4.

// 0,5   7,0  -2,0  -0,2
// 1,0  -3,3   8,0  -9,9
// 8,0   7,8  -7,1   9,0


double[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    //                        0       1
    double[,] matrix = new double[rows, columns]; // rows = 3, columns = 4
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[i, j] =  Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }

    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5}"); //({matrix[i, j] + "\t"}");
        }
        Console.WriteLine("|");
    }

}

double[,] array2d = CreateMatrixRndInt(3, 4, -5, 5);
PrintMatrix(array2d);