// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



int[] GetArray()
{
    int[] arr = new int[8];
    for (int i = 0; i < 8; i++)
    {
        arr[i] = new Random().Next();
    }

    return arr;
}


int[] array = GetArray();
Console.WriteLine($" [ {String.Join(", ", array)} ] ");