// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N. 
//  Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int UserNumber(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int SumOfDigits(int m, int n)
{
    if (m > n) return n + SumOfDigits(m, n + 1);
    if (m < n) return n + SumOfDigits(m, n - 1);
    if (m == n) return n;
    else return m + SumOfDigits(m + 1, n); 
   
}

int m = UserNumber("Введите значение m: ");
int n = UserNumber("Введите значение n: ");
if (m < 1)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}


Console.WriteLine($"Сумма натуральных элементов равно {SumOfDigits(m, n)}");