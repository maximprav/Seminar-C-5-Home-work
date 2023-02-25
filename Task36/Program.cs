// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int OddPositionSum(int[] array)
{
    int sum = 0;
    int size = array.Length;
    for (int i=0; i<size; i++)
    {
        if (i%2>0)
        {
            sum = sum + array[i];
        }
    }
    Console.WriteLine($"Сумма чисел на нечетных позициях массива равна {sum}");
    return sum;
}

int[] array88 = GetArray(6, -10, 10);
PrintArray(array88);
OddPositionSum(array88);