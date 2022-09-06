// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void CubesOfNumber(int num) // метод считает кубы от 1 до введенного числа и выводит
{
    int count = 1;
    while (count <= num)
    {
        int cubeRes = count * count * count;
        Console.WriteLine($"{count} -> {cubeRes}");
        count++;
    }
}

Console.Clear();
Console.Write("Введите целое положительное число > 0: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 1) CubesOfNumber(number);
else Console.WriteLine("Ошибка ввода. Введите целое положительное число > 0.");
