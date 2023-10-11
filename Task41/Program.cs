// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



int GetUserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] CreaterArrarRndint(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = GetUserInput($"Введите {i + 1}-й элемент");
    }
    return array;
}
void PrintOut(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[^1]} ]");
}

int CountNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

int num = GetUserInput("Введите числа: ");
int[] randArr = CreaterArrarRndint(num);
PrintOut(randArr);
Console.WriteLine($"Количество чисел больше 0 -> {CountNumber(randArr)}");