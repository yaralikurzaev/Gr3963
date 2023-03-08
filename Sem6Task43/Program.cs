// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


string Coordinate(int b1, int k1, int b2, int k2)
{
    double numberX = (b2 - b1) / (k1 - k2);
    double numberY = k2 * numberX + b2;
    string res = $"Точка пересечения ваших прямых: ( {numberX}; {numberY}) ";
    return res;
}

Console.WriteLine(Coordinate(ReadData("Введите координату b1: "), ReadData("Введите координату k1: "), ReadData("Введите координату b2: "), ReadData("Введите координату k2: ")));