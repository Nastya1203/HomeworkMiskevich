// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// // значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



double GetUserInput(string str)
{
    Console.WriteLine(str);
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    int x = 0;
    int y = 1;
    lineData[x] = GetUserInput($"введите коэффициент для {numberOfLine} прямой > ");
    lineData[y] = GetUserInput($"введите коэффициент для {numberOfLine} прямой > ");
    return lineData;
}

double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[x_coord] = (lineData1[y] - lineData2[y]) / (lineData2[x] - lineData1[x]);
    coord[y_coord] = (lineData1[y] * coord[x_coord] + lineData1[y]);
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[x] == lineData2[x])
    {
        if (lineData1[y] == lineData2[y]) ;
        Console.WriteLine("Прямые совпадают");
        return false;
    }
    else
    {
        Console.WriteLine("Прямые параллельны");
        return false;
    }
}

double num1 = GetUserInput("Введите значение b1");
double num2 = GetUserInput("Введите значение k1");
double num3 = GetUserInput("Введите значение b2");
double num4 = GetUserInput("Введите значение k2");

double[] lineData1 = InputLineData(num);
double[] lineData2 = InputLineData(num);

double[] findCoords = FindCoords(lineData1,lineData2);
bool validateLines = ValidateLines(lineData1,lineData2);

// Console.WriteLine("введите значение b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите значение b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k2");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (-b2 + b1)/(-k1 + k2);
// double y = k2 * x + b2;

// Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");