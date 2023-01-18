/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] SetArray(int N, int a, int b)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b);
    }
    return arr;
}

int EvenNumArray(int[] arr)
{
    int evenCount = 0;
    foreach (int num in arr)
    {
        evenCount += (num % 2 == 0) ? 1 : 0;
    }
    return evenCount;
}
Console.WriteLine();
Console.Write("Введите размер массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
int[] myArr = SetArray(sizeArr, 100, 1000);
Console.WriteLine();
Console.WriteLine($"[{String.Join(", ", myArr)}] -> {EvenNumArray(myArr)}");
Console.WriteLine();
