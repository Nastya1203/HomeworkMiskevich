// Напишите программа, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3d пространстве.

int GetUserInput(string message)
{
    Console.Write($"{message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

// d = √((хА –  хВ)2 + (уА – уВ)2)
double Distance(int x1, int y1, int x2, int y2, int z1, int z2)
{
    double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return res;
}

int x1 = GetUserInput("Координаты первой точки\nВведите координату X");
int y1 = GetUserInput("Координаты первой точки\nВведите координату Y");
int z1 = GetUserInput("Координаты первой точки\nВведите координату Z");
Console.WriteLine("------------------------------");
int x2 = GetUserInput("Координаты второй точки\nВведите координату X");
int y2 = GetUserInput("Координаты второй точки\nВведите координату Y");
int z2 = GetUserInput("Координаты первой точки\nВведите координату Z");

double distance = Distance(x1, y1, x2, y2, z1, z2);
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));