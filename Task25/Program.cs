// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int GetUserInput(string msg)
{
    Console.WriteLine($"{msg}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Pow(int a, int b)
{
   int pow = 1;
   for (int i = 0; i < b; i++)
   {
    pow *= a;
   }
   return pow;
}


int a = GetUserInput("Введите первое число: ");
int b = GetUserInput("Введите второе число: ");
int pow = Pow(a,b);
Console.WriteLine($"{a}, {b} -> {pow}");