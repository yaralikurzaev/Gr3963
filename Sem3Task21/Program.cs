// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//метод принимает число от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//метод выводит сообщение
void PrintData(string msg, double val)
{
    Console.WriteLine(msg + val);
}
//метод считает растояние между точками
double CalkLen(int x1, int x2, int z1, int y1, int y2, int z2)
{
    return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)+(z1 - z2) * (z1 - z2));
}

//решение задания
int xU1 = ReadData("Введите x1 точки А: ");
int yU1 = ReadData("Введите y1 точки А: ");
int zU1 = ReadData("Введите z1 точки А: ");
int xU2 = ReadData("Введите x2 точки Б: ");
int yU2 = ReadData("Введите y2 точки Б: ");
int zU2 = ReadData("Введите z2 точки Б: ");
double res = CalkLen(xU1, xU2,zU1, yU1, yU2, zU2);
PrintData("Расстояние между точками А и Б: ", res);