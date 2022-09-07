// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int NumberLength(int num)   // вычисляем кол-во разрядов в числе
{
    int countDigits = 0;
    while (num > 0)
    {
        num /= 10;
        countDigits++;
    }
    return countDigits;
}

double RevertNumber(int num, int numLength) // реверс числа
{
    double sum = 0;
    int i = numLength - 1;
    while (i >= 0)
    {
        int digit = num % 10;
        sum = sum + Math.Pow(10, i) * digit;
        num /= 10;
        i--;
    }
    return sum;
}

Console.Clear();
Console.Write("Введите целое пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)   // проверка, что вводится 5-ти значное число
{
    int lenNum = NumberLength(number);    // определяем разрядность числа
    int revertNum = (int)RevertNumber(number, lenNum);    // делаем реверс числа

    if (number == revertNum) Console.WriteLine($"{number} -> палендром");
    else Console.WriteLine($"{number} -> не палендром");
}
else Console.WriteLine("Ошибка ввода. Введите целое пятизначное число.");
