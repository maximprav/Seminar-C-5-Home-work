// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
} 

void PrintArray(int[] array)
{
    int size = array.Length;
    for (int i=0; i<size; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int MaxInArray(int[] array)
{
    int size = array.Length;
    int max = array[0];
    for(int i=1; i<size; i++)
    {
        if (array[i]>max)
        {
            max = array[i];
        }
    }
    Console.WriteLine($"Максимальное число в массиве {max}");
    return max;
}

int MinInArray(int[] array)
{
    int size = array.Length;
    int min = array[0];
    for(int i=1; i<size; i++)
    {
        if (array[i]<min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($"Минимальное число в массиве {min}");
    return min;
}

int[] array88 = GetArray(6, 0, 20);
PrintArray(array88);
// MaxInArray(array88);
// MinInArray(array88);
int diff = MaxInArray(array88) - MinInArray(array88);
Console.WriteLine($"Разница между максимальным и минимальным числом равна {diff}");