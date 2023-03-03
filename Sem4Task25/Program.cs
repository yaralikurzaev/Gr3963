// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// * Написать калькулятор с операциями +, -, /, * и возведение в степень

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

double Pow(int a, int b)
{
    double res = Math.Pow(a,b);
    return res;
}

double stepen = Pow(ReadData("Введите число: "),ReadData("Введите степень в которую хотите возвести: "));
Console.WriteLine("Результат: "+ stepen);
