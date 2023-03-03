// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// * Сделать оценку времени алгоритма через вещественные числа и строки

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int CalkNum(int numOf)
{
    int digitCount = (int)Math.Log10(numOf) + 1;
    int sumNum = 0;
    for (int i = 0; i < digitCount; i++)
    {
        sumNum = sumNum + numOf%10;
        numOf = numOf/10;
    }
    return sumNum;
}
Console.WriteLine("Сумма чисел: " + CalkNum(ReadData("Введите число, у которого посчитать сумму цифр: ")));