// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


int GetUserPrint(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int day = GetUserPrint("Введите цифру, обозначающую день недели: ");

bool IsWeekend (int day)
{
    if (day > 5)
    {
        return true;
    }
    return false;
}
 
if (IsWeekend(day))
 {
    Console.WriteLine("выходной");
 }
 else
 {
    Console.WriteLine("не выходной");
 }