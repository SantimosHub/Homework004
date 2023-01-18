// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int SumDigit(int number)
// {
//     int sum = 0;
//     while (number / 10 != 0)
//     {
//         sum += number % 10;
//         number = number / 10;
//     }
//     sum += number % 10;
//     return sum;
// }

int SumDigit(int number)
{
    int sum = 0;
    for (int i = number; i > 0; i = i / 10)
    {
        sum += i % 10;
    }
    return sum;
}

Console.Write("Введите число : ");
int num = Math.Abs(int.Parse(Console.ReadLine()));
Console.WriteLine($"Сумма цифр = {SumDigit(num)}");