// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int ExpResult(int numberA, int numberB)
{
    int result = numberA;
    for (int i = 2; i <= numberB; i++) 
    {
        result *= numberA;
    }
    return result;
}

Console.Write("Введите число A: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = int.Parse(Console.ReadLine());

Console.WriteLine($"{numA} в степени {numB} = {ExpResult(numA, Math.Abs (numB))}");