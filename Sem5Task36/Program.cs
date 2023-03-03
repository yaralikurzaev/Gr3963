// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0


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

int OddSum(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i = i + 2)
    {
        res = res + arr[i];
    }
    return res;
}

int[] array = ArrayGen1D(ReadData("Введите длину массива: "), ReadData("Введите минимальное число массива: "), ReadData("Введите максимальную массива: "));
ArrayPrint1D(array);
int res = OddSum(array);
Console.WriteLine("Сумма нечетных чисел: " + res);
