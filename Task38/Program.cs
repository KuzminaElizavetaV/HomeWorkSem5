/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
[1,2 45,45 32,18 110,34 15,06] -> 109,14
*/

double[] GetArray(int num)
{
    double[] arr = new double[num];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите значение элемента маcсива: ");
        arr[i] = Convert.ToDouble(Console.ReadLine());
    }
    return arr;
}

Console.WriteLine();
Console.Write("Введите размер массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
double[] array = GetArray(sizeArr); 

double DiffMaxMinArray(double[] arr)
{
    double minArr = arr[0];
    double maxArr = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        minArr = arr[i] < minArr ? arr[i] : minArr;
        maxArr = arr[i] > maxArr ? arr[i] : maxArr;
    }
    return maxArr - minArr;
}
Console.WriteLine();
Console.WriteLine($"[{String.Join(" ", array)}] -> {Math.Round(DiffMaxMinArray(array),2)}");
Console.WriteLine();
