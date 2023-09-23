// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает,что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int GetUserPrint(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int number = GetUserPrint("Введите число: ");

int OutputsThirdDigit(int num)
{
    return number % 10;
}

int outputsThirdDigit = OutputsThirdDigit(number);
Console.WriteLine($"{number} -> {outputsThirdDigit}");
