//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.
//N = 5 -> "1, 2, 3, 3, 4"
//N = 8 -> "1, 2, 3, 4, 5, 6, 7, 8"


//Принимаем из консоли число
int ReadInputInt(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

//Метод, который выводит в консоль сообщение
void PrintData(string mess)
{
    Console.WriteLine(mess);
}


//Строка  в которой  все натуральные числа в промежутке от 1 до N
string LineGenRec(int N, int numer)
{
    string res = String.Empty;

    if (numer <= N)
    {
        res += numer + " " + LineGenRec(N, numer + 1);
        return res;
    }
    else
    {

        return res;
    }
}


int num = ReadInputInt("Введите до какого числа выводить последовательность: ");
PrintData($"{LineGenRec(num, 1)}");