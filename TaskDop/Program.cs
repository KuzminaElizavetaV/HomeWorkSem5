/*Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сортировку (т.е. по убыванию).
[3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
[1,2,2,3,2] -> [3, 2, 2, 2, 1]*/

int[] SetArray(int N, int a, int b)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b);
    }
    return arr;
}

int[] BubbleSortDescending(int[] arr) //реализация функции сортировка пузырьком по убыванию
{
    for (int i = 1; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - i; j++)
        {
            if (arr[j] < arr[j + 1])
            {
                (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
            }
        }
    }
    return arr;
}

Console.Write("Задайте размер массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте начальное значение для диапазона элементов массива: ");
int beginNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте конечное значение для диапазона элементов массива: ");
int endNum = Convert.ToInt32(Console.ReadLine());
int[] array = SetArray(sizeArr, beginNum, endNum);
Console.WriteLine($"[{String.Join(", ", array)}] -> [{String.Join(", ", BubbleSortDescending(array))}]");


