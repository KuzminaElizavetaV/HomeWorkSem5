/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] SetArray(int N, int a, int b)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b);
    }
    return arr;
}

int SumOfOddIndexArray(int[] arr)
{
    int sumIndex = 0;
    for (int i = 1; i < arr.Length; i += 2)
        sumIndex += arr[i];
    return sumIndex;
}
Console.WriteLine();
Console.Write("Введите размер массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало диапазона элементов массива: ");
int beginNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите окончание диапазона элементов массива: ");
int endNum = Convert.ToInt32(Console.ReadLine());

int[] array = SetArray(sizeArr, beginNum, endNum);
Console.WriteLine();
Console.WriteLine($"[{String.Join(", ", array)}] -> {SumOfOddIndexArray(array)}");
Console.WriteLine();

