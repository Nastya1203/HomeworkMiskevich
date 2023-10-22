// // Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// // m = 2, n = 3 -> A(m,n) = 9
// // m = 3, n = 2 -> A(m,n) = 29


int UserNumber(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

int Akkerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else 
    if(m == 0 && n != 0 )
    {
        return Akkerman(n - 1, 1);
    }
    else
    {
        return Akkerman(n - 1, Akkerman(n, m - 1));
    }
}

int m = UserNumber("Введите значение m: ");
int n = UserNumber("Введите значение n: ");

int akkerman = Akkerman(m, n);
Console.WriteLine($"{akkerman}");