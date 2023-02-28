/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6]-> 0*/

int[] GenArray(int size)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(0, 99);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int SumOfNechet(int[] array)
{
    int sum = 0;
    for (int i = 1;i < array.Length;i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int[] newArray = GenArray(6);
PrintArray(newArray);
Console.WriteLine(SumOfNechet(newArray));