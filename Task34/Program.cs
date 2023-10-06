// Задача 34: Задайте массив заполненный случайными положительными 
// трехзначными числами. Напишите программу, которая покажет количество
// четных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] CreaterArrarRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintOut(int[] arr)
{
     Console.Write("[");
    for (int i = 0; i < arr.Length -1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[^1]} ]");
}

int AmountOfEvenNumber(int[] arr)
{
    int count =0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 ==0) count++;
    }
    return count;
}

int[] randArr = CreaterArrarRndInt(4, 100, 1000);
PrintOut(randArr);
int amountOfEvenNumber = AmountOfEvenNumber(randArr);
Console.WriteLine($" -> {amountOfEvenNumber}");