/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/
Console.Clear();
Console.Write("Enter 5 numbers + space: ");
string num = Console.ReadLine();
int[] Basearray = GetArrayFromString(num);
Console.WriteLine(DifMaxMin(Basearray));

int[]GetArrayFromString(string stringArray)
{
    string[]ar = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[]res = new int[ar.Length];
    for(int i=0; i < ar.Length; i++)
    {
        res[i] = int.Parse(ar[i]);
    }
    return res;
}
/*int DifMaxMin(int[]array)
{
    int MaxN = array[0];
    int MinN = array[0];
    
    for( int i =1; i < array.Length; i++)
    {
        if (array[i] > MaxN) MaxN = array[i];
        else
        if(array[i] < MinN) MinN = array [i];
    }
    int dif = MaxN - MinN;
    return dif;
}*/
int DifMaxMin (int[] Basearray)
{   
    int[] result = new int [2];
    result[0] = Basearray[0];
    result[1] = Basearray[0];
    foreach(var el in Basearray)
    {
        result[0] = el > result[0] ? el : result[0];
        result[1] = el < result[1] ? el : result[1];
    }
    int dif = result[0]- result[1];
    return dif;
}