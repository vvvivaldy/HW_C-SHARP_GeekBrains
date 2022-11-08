// задачи №60 и №62 написаны в папке HW_lesson#7_AdditionalTasks

Console.Write("введите размерность массива: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write(" ");
int b = int.Parse(Console.ReadLine()!);

int[,] arr = GetArr(a,b);
WriteArr(arr);

Console.Write("Измененный массив: ");
WriteArr(SortDecreaseArr(arr));

int[,] SortDecreaseArr (int[,] arr)
{
    for (int i = 0; i<arr.GetLength(0); i++)
    {
        Array.Sort(arr[i,]);
    }
    return arr;
}

int[,] GetArr(int a, int b)
{
    int[,] result = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            result[i, j] = new Random().Next(10);
        }
    }
    return result;
}

void WriteArr (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}