// Задача 38: Задайте масиив вещественных чисел.
// Найдите разницу между макс-ым и мин-ым элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] CreaterArrarRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]:F1}, ");
        else Console.Write($"{arr[i]:F1}");
    }
    Console.WriteLine("]");
}

double Difference(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > min) arr[i] = max;
        if(arr[i] < max) arr[i] = min;
    }
    return max-min;
}

double[] array = CreaterArrarRndDouble(4, 1.1, 100);
PrintArrayDouble(array);

int difference = Difference(array);
Console.WriteLine(difference);
