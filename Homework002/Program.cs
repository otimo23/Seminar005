/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
Console.Clear();
int[] array = RanMas(6, 0, 10);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"{SumEvPos(array)}");

int [] RanMas (int size, int minValue, int MaxValue)
{
    int[] res = new int [size];
    for(int i = 0; i < size; i++)
    {
    res[i] = new Random().Next(minValue, MaxValue+1);
    }
    return res;
}
int SumEvPos(int[]array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i= i+2)
    {
        sum = sum + array[i];
    }
    return sum;
}

