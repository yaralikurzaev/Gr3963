// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
//Решение для 5ти значного числа
//Метод для возвращения числа от пользователя

int ReadData(string msg)
 {
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
 }
 //метод для проверки палиндром или нет
 bool PalinTest(int numTest)
 {
     bool res = false;
     if (numTest / 10000 == numTest % 10 && (numTest / 1000) % 10 == (numTest / 10) % 10)
     {
         res = true;     
}
    return res;
 }

int num = ReadData("введите 5-ти значне число: ");
 if (PalinTest(num))
{
     Console.WriteLine("Ваше число - палиндром");
}
else
{
    Console.WriteLine("Ваше число - не палиндром");
 }