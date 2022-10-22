// 1-st Addition Task


// WriteArr3D (RemovingRepetitions (2, 2, 2,
//                                 GetArr3D (2, 2, 2)));


// int[,,] GetArr3D(int a, int b, int c)
// {
//     int[,,] result = new int[a, b, c];
//     for (int i = 0; i < a; i++)
//     {
//         for (int j = 0; j < b; j++)
//         {
//             for (int k = 0; k < c; k++)
//             {
//                 result[i, j, k] = new Random().Next(0, 100);
//             }
//         }
//     }
//     return result;
// }

// int [,,] RemovingRepetitions (int a, int b, int c, int[,,] arr)
// {
//     // проверка массива на повторения
//     int count = 0;
//     do {
//         for (int i = 0; i < a; i++){
//             for (int j = 0; j < b; j++){
//                 for (int k = 0; k < c; k++){
//                     for (int i2 = 0; i2 < a; i2++){
//                         for (int j2 = 0; j2 < b; j2++){
//                             if (k == 0 && arr[i,j,k] == arr[i2,j2,1])
//                             {
//                                 arr[i,j,k]++;
//                             } else if (k == 1 && arr[i,j,k] == arr[i2,j2,0])
//                             {
//                                 arr[i,j,k]++;
//                             }
//                         }
//                     }
//                 }
//             }
//         }
//         count++;
//     } while (count < a*b*c);
//     return arr;
// }

// void WriteArr3D (int[,,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 Console.Write($"{arr[i,j,k]}({i},{j},{k}) ");
//             }
//             Console.WriteLine();
//         }
//     }
// }




// 2-nd Addition Task


// немного перевыполню задачу и для красоты спирально заполню любой массив квадратного размера с четными сторонами и числами начиная со 100
// на листочке находил закономерности,так что имею право :D
// Console.Write("Введите размер стороны квадратного массива (четное число): ");
// int size = int.Parse(Console.Readline()!);
int size = 6;
int[,] arr = new int [size,size];

// заполним первую строку массива
for (int i =0; i<size; i++)
{
    arr[0,i]=100 + i;
}

// а дальше магия)
int n = size; // переменная n создана исключительно для меня, т.к. на бумаге у меня обозначены позиции с помощью n
int line = 0;
int col = n-1;
int current = arr[0,n-1] +1; // потому что  первая строка массива заполнена. Это актуальное число
while (n>0)
{
    for (int i = line+1; i<n; i++){
        arr[i,col] = current;
        current++;
        line = i;
    }
    for (int j = col-1; j>=0; j--){
        arr[line,j] = current;
        current++;
        col=j;
    }
    n--;
}





// вывод массива
for (int i =0;i<size;i++)
{
    for (int j=0;j<size;j++)
    {
        Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
}