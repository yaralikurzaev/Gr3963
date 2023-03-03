// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6


int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

double[] ArrayGen1D(int num, int min, int max)
{
    if (min > max)
    {
        (min, max) = (max, min);
    }

    double[] array = new double[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(min, max) + Math.Round(new Random().NextDouble(),2);
        
    }
    return array;
}

void ArrayPrint1D(double[] arrayPrint)
{
    Console.Write("[ ");
    for (int i = 0; i < arrayPrint.Length - 1; i++)
    {
        Console.Write(arrayPrint[i] + ", ");
    }
    Console.WriteLine(arrayPrint[arrayPrint.Length - 1] + " ]");

}

double SubMaxMin(double[] arr)
{
    double res = 0, max = arr[0], min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    if(min<0)
    {
        min = -min;
    }

    res = Math.Round(max - min, 2);
    return res;
}

double[] arr = ArrayGen1D(ReadData("Введите длину массива: "), ReadData("Введите минимальное число массива: "), ReadData("Введите максимальную массива: "));
ArrayPrint1D(arr);
double res = SubMaxMin(arr);
Console.WriteLine("Разница между максимальным и минимальным числом: " + res);