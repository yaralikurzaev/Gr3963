// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и
// выдает сколько чисел больше 0 было введено.

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int CountNum(int numN)
{
    int res = 0;
    for (int i = 0; i < numN; i++)
    {
        if (ReadData("введите ваше число: ") > 0)
        {
            res++;
        }
    }
    return res;
}
int numA = CountNum(ReadData("Сколько чисел у вас всего? У меня вот столько чисел: "));
Console.WriteLine($"Среди ваших чисел больше нуля {numA}");