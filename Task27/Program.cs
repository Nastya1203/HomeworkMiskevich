// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetUserInput(string msg)
{
    Console.WriteLine($"{msg}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int SunNumbers(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}


int number = GetUserInput("Введите число");
int sunNumbers = SunNumbers(number);

Console.WriteLine($"сумму цифр {number} -> {sunNumbers}");