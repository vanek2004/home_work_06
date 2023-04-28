// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("- Введите значения двух прямых -");
Console.Write("b1 - ");
int numberb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 - ");
int numberb2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1 - ");
int numberk1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 - ");
int numberk2 = Convert.ToInt32(Console.ReadLine());

bool checkingLines = CheckingLines(numberb1, numberb2, numberk1, numberk2);
Console.Write(checkingLines ? "Точка пересечения двух прямых - ":"");

double checking1 = Checking1(numberb1, numberb2, numberk1, numberk2);
Console.Write($"({checking1}; ");
double checking2 = Checking2(numberb1, numberb2, numberk1, numberk2);
Console.Write($"{checking2})");


bool CheckingLines (int b1, int b2, int k1, int k2)
{
    if (k1 == k2 && b1 == b2 ) 
    {
        Console.Write("Прямые параллельны");
        return false;
    }
    else if (k1 == k2)
    {
        Console.Write("Прямые совпадают");
        return false;
    }
    return true;
}

double Checking1 (double b1, double b2, double k1, double k2)
{
    double x = 0;
    double y1 = 0;
    x = (b2 - b1) / (k1 - k2);
    y1 = k1 * x + b1;
    return y1;
       
}
double Checking2 (double b1, double b2, double k1, double k2)
{
    double x = 0;
    double y2 = 0;
    x = (b2 - b1) / (k1 - k2);
    y2 = k2 * x + b2;
    return y2;
       
}
// double CheckingLines(int b1, int b2, int k1, int k2)
// {
//     double x = 0;
//     double y1 = 0;
//     double y2 = 0;
//     if (k1 == k2 && b1 == b2) Console.Write("Прямы совпадают");
//     else if (k1 == k2) Console.Write("Прямы параллельны");
//     else
//     {
//         x = (b2 - b1) / (k1 - k2);
//         y1 = k1 * x + b1;
//         y2 = k2 * x + b2;
//     }
//     return y1;
// }
