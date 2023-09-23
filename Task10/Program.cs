// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трёхзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine()); 

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int num = GetUserInput("Введите трёхзначное число: ");

int ShowSecondDigit(int number)
{
    int firstDigit = number % 100;
    int thirdDigit = number % 10;
    return (num % 100 - number % 10) / 10;
}
 
 int showSecondDigit = ShowSecondDigit(num);
 Console.Write($"{num} -> {showSecondDigit}");



