// Напишите программу, которая принимает на вход число (N) 
// и выдает таблицу кубов чисел от 1 до N.

void SquareNumbers (int num) 
{
    int count = 1;
    while (count <= num) {
        Console.WriteLine($"{count, 3} -> {count*count*count, 5}");
        count++;
    }
}


Console.WriteLine ("Введите число:");
int userNum = Convert.ToInt32(Console.ReadLine());
SquareNumbers(userNum);