// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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
            arr[i, j] = new Random().Next(-10, 10); ;
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
//Метод для нахождения определенного цисла в двойном массиве, путем введения определеного столбца и строки.
int SearchNumberInArr2D(int[,] arr, int columns, int rows)
{
    int res = 0;
    if (columns < arr.GetLength(0) && rows < arr.GetLength(1))
    {
        res = arr[columns - 1, rows - 1];

    }
    else
    {
        Console.WriteLine("Поиск вышел за пределы созданного массива.");
    }
    return res;
}
// Вывод в консоль
int[,] arr = Gen2DArrMod(ReadData("Введите количество строк вашего массива: "), ReadData("Введите количество столбцов вашего массива: "));
Print2DArrColor(arr);
int res = SearchNumberInArr2D(arr, ReadData("Введите столбец для поиска: "), ReadData("Введите строчку для поиска в массиве: "));
if (res == 0)
{
    Console.WriteLine("Попробуйте еще раз задать параметры поиска.");
}
else
{
    Console.WriteLine($"Ваше число в заданном поиске = {res}");
}