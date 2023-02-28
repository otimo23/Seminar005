/* **Задача 32:**Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.*/
Console.Clear();
int[] startArray = GetArray(5,  -10, 10);
Console.WriteLine(String.Join (", ", startArray));
Console.WriteLine(String.Join(", ", InverseArray(startArray)));

int [] GetArray (int size, int minValue, int maxValue)
{
    int[]array = new int [size];
    for (int i = 0; i < size; i++)
    {
    array[i] = new Random().Next(minValue,maxValue+1);
    }
    return array;
}
int [] InverseArray (int [] array)
{
    for(int i = 0; i < array.Length; i++)
    array[i]= array[i] * -1;
    return array;
}
