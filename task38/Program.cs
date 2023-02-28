/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

double[] GenArray(int size)
{
    double[] array = new double[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(0, 99);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double FindDiffBetweenMaxAndMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
    }
    double diff = max - min;
    return diff;
}

double[] newArray = GenArray(5);
PrintArray(newArray);
Console.WriteLine(FindDiffBetweenMaxAndMin(newArray));