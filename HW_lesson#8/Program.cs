// задачи №60 и №62 написаны в папке HW_lesson#7_AdditionalTasks

Console.Write("введите размерность массива: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write(" ");
int b = int.Parse(Console.ReadLine()!);

WriteArr(GetArr(a,b));

Console.Write("Измененный массив: ");

int[,] SortDecreaseArr (int[,] arr)
{
    int max;
    int temp;
    for (int i = 0; i<arr.GetLenth(0); i++)
    {
        max = arr[i,0];
        for (int j = 1;j<arr.GetLenth(1);j++)
        {
            if (max < arr[i,j])
            {
                arr[]
                
            }
        }
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