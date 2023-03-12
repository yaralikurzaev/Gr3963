//Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18


//Принимаем из консоли число
int ReadInputInt(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

//Генерируем массив случайными числами
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

// выводим двумерный массив на экран для демонстрации умножения матриц
void Print2DArr(int[,] arr, int left)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.SetCursorPosition(left,i);
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiply(int[,] arr1, int[,] arr2)
{
    int rows1 = arr1.GetLength(0);
    int columns1 = arr1.GetLength(1);
    int rows2 = arr2.GetLength(0);
    int columns2 = arr2.GetLength(1);


    // Создаем массив для результирующей матрицы
    int[,] result = new int[rows1, columns2];

    // Вычисляем произведение матриц
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            int sum = 0;
            for (int k = 0; k < columns1; k++)
            {
                sum += arr1[i, k] * arr2[k, j];
            }
            result[i, j] = sum;
        }
    }

    return result;
}


int lengthMas1 = ReadInputInt("Введите количество строк и столбцов для первого двумерного массива: ");
int lengthMas2 = ReadInputInt("Введите количество строк и столбцов для второго двумерного массива: ");


int[,] mas1 = Gen2DArrRandom(lengthMas1, lengthMas1, 10, 100);
int[,] mas2 = Gen2DArrRandom(lengthMas2, lengthMas2, 10, 100);

Console.Clear();

if (lengthMas1 != lengthMas2)
{
    Console.WriteLine("Введеные массивы не подходят по размерам");
    
}
else
{
    int[,] mas3 = MatrixMultiply(mas1, mas2);
    int pix = mas1[0,0].ToString().Length + 3;
    int left = pix * lengthMas1;
    Print2DArr(mas1,0);
    Console.SetCursorPosition( left + 2 , lengthMas1/2);
    Console.Write("*");
    Print2DArr(mas2, left + 8);
    Console.SetCursorPosition(left * 2 + 9, lengthMas1/2);
    Console.Write("=");
    Print2DArr(mas3, left * 2 + 15);
}