// №34 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1


int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[] ArrayGen1D(int num, int min, int max)
{
    if (min > max)
    {
        (min, max) = (max, min);
    }

    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ArrayPrint1D(int[] arrayPrint)
{
    Console.Write("[ ");
    for (int i = 0; i < arrayPrint.Length - 1; i++)
    {
        Console.Write(arrayPrint[i] + ", ");
    }
    Console.WriteLine(arrayPrint[arrayPrint.Length - 1] + " ]");

}

int SearchEven(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}

int[] array = ArrayGen1D(ReadData("Введите длину массива: "), ReadData("Введите минимальное число массива: "), ReadData("Введите максимальную массива: "));
ArrayPrint1D(array);
int res = SearchEven(array);
Console.WriteLine("Количество четных: " + res);
