using System;
using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите параметры");

        string[] paramList = Console.ReadLine().Split();
        double square;
        bool isRight = false;

        if (paramList.Length == 1)
        {
            square = GeometryLib.GetSquare(double.Parse(paramList[0]));
        } else
        {
            square = GeometryLib.GetSquare(double.Parse(paramList[0]), double.Parse(paramList[1]), double.Parse(paramList[2]));
            isRight = GeometryLib.IsRightTriangle(double.Parse(paramList[0]), double.Parse(paramList[1]), double.Parse(paramList[2]));

        }

        Console.WriteLine(square);
        Console.WriteLine(isRight);
    }
}