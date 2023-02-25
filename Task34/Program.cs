// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

void PrintArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int EvenNumbers(int[] array)
{
    int count = 0;
    int size = array.Length;
    for (int i=0; i<size; i++)
    {
        if (array[i]%2==0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество четных чисел равно {count}");
    return count;
}

int[] array88 = GetArray(10, 100, 999);
PrintArray(array88);
EvenNumbers(array88);
