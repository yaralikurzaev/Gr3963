//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2


//Принимаем из консоли число
int ReadInputInt(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

//Метод, который генерирует массив случайными числами
int[,] Gen2DArrRandom(int row, int colum, int bottom, int top)
{
    Random rnd = new Random();
    int[,] arr = new int[row, colum];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            arr[i, j] = rnd.Next(bottom, top);
        }
    }
    return arr;
}

// выводим двумерный массив на экран с разукрашиванием элемента если он равен тому что ввёл пользователь
void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// Метод для сортировки элементов каждой строки массива по убыванию
void Sort2DRows(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, k] > arr[i, j])
                {
                    int temp = arr[i, k];
                    arr[i, k] = arr[i, j];
                    arr[i, j] = temp;
                }
            }
        }
    }
}



int countRow = ReadInputInt("Введите количество строк для двумерного массива: ");
int countColum = ReadInputInt("Введите количество столбцов для двумерного массива: ");
int min = ReadInputInt("Введите 1 границу последовательности: ");
int max = ReadInputInt("Введите 2 границу последовательности: ");
if (min > max) (min, max) = (max, min);

int[,] mas = Gen2DArrRandom(countRow, countColum, min, max);

Console.WriteLine("Исходный массив:");
Print2DArr(mas);

Sort2DRows(mas);

Console.WriteLine("Отсортированный массив:");
Print2DArr(mas);