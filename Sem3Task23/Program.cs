// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом

//принимаем число от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//метод возводящий в степень и возвращает строку
string LineBuilder(int num, int pow)
{
    string res = String.Empty;
    for (int i = 1; i <= num; i++)
    {
        res = res + Math.Pow(i, pow) + " \t |";
    }
    return res;
}
//решение задачи
int nOf = ReadData("Введите число до какого числа показать: ");
int pOf = ReadData("Введите в какую степень возввести числа (для решения задания введите `3`): ");
Console.WriteLine(LineBuilder(nOf, 1));
Console.WriteLine(LineBuilder(nOf, pOf));