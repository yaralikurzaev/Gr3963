//Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


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

int SumNumerRec(int M, int N)
{
    int res = 0;

    if (M > N) return res;
    else
    {   
        res += M + SumNumerRec(M + 1, N);
        return res;
    }
}

int num1 = ReadInputInt("Введите 1 границу промежутка сумирования: ");
int num2 = ReadInputInt("Введите 2 границу промежутка сумирования: ");
if (num1 > num2) (num1, num2) = (num2, num1);

PrintData($"Ответ = {SumNumerRec(num1, num2)}");