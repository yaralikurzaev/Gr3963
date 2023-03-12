//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29



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

int AckermannRec(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AckermannRec(m - 1, 1);
    }
    else
    {
        return AckermannRec(m - 1, AckermannRec(m, n - 1));
    }
}

int num1 = ReadInputInt("Введите 1 неотрицательное число: ");
int num2 = ReadInputInt("Введите 2 неотрицательное число: ");

if (num1 < 0 || num2 < 0) PrintData("1 или оба ввёденых чисел отрицательные");
else PrintData ($"A({num1},{num2}) = {AckermannRec(num1,num2)}");