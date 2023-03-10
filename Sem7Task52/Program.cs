// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// Метод для нахождения двойного массива модифицированный
int[,] Gen2DArrMod(int countRow, int countColumn)
{

    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = new Random().Next(0, 11); ;
        }
    }
    return arr;
}
// Метод для разукраски цифр в двойном массиве
void Print2DArrColor(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0, 16)];
            Console.Write(arr[i, j] + "\t ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
// Метод для нахождения среденого арифметического числа.
void AverageInArr(int[,] arr)
{
    double res = 0;
    double temp = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            temp = temp + arr[j, i];
        }
        res = Math.Round(temp/arr.GetLength(0),2);
        temp = 0;
        Console.Write($"{res};\t ");
    }
}
// Вывод в консоль.
int[,] arr = Gen2DArrMod(ReadData("Введите количество столбцов вашего массива: "), ReadData("Введите количество строк вашего массива: "));
Print2DArrColor(arr);
AverageInArr(arr);
