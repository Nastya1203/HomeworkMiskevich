// Напишите программа, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом


int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


bool IsFifthDigit(int number)
{
    if (number > 9999 && number < 100000)
    {
        return true;
    }
    Console.WriteLine("Число не пятизначное");
    return false;
}

bool IsPalindrom(int num)
{
    if ((num / 10000 == num % 10 ) & (num / 1000 % 10 == num % 100 / 10))
    {
        return true;
    }
    return false;
}

int num = GetUserInput("Введите пятизначное число");
bool isFifthDigit = IsFifthDigit(num);
bool result = IsPalindrom(num);
Console.WriteLine(result);
