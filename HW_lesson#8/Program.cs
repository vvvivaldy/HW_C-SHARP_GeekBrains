// задачи №60 и №62 написаны в папке HW_lesson#7_AdditionalTasks

// // номер 1
// Console.Write("введите размерность массива: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write(" ");
// int b = int.Parse(Console.ReadLine()!);


// int[,] arr = GetArr(a,b);
// WriteArr(arr);

// Console.WriteLine("Измененный массив: ");

// WriteArr(SortDecreaseArr(arr));

// int[,] SortDecreaseArr (int[,] arr)
// {
//     int temp;
//     for (int i = 0; i<arr.GetLength(0); i++)
//     {
//         for (int j = 0;j<arr.GetLength(1);j++) // ходит по элементам массива
//         {
//             for (int h = j+1 ;h<arr.GetLength(1); h++) // определяет максимальный элемент в этой строке и меняет с текущем элементом j
//             {
//                 if (arr[i,j] < arr[i,h])
//                 {
//                     temp = arr[i,j];
//                     arr[i,j] = arr[i,h];
//                     arr[i,h] = temp;
//                 }
//             }
//         }
//     }
//     return arr;
// }

// int[,] GetArr(int a, int b)
// {
//     int[,] result = new int[a, b];
//     for (int i = 0; i < a; i++)
//     {
//         for (int j = 0; j < b; j++)
//         {
//             result[i, j] = new Random().Next(10);
//         }
//     }
//     return result;
// }

// void WriteArr (int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// // номер 2
// Console.Write("введите размерность массива: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write(" ");
// int b = int.Parse(Console.ReadLine()!);


// int[,] arr = GetArr(a,b);
// WriteArr(arr);

// Console.WriteLine("Строка с минимальной суммой значений: " + (MinStrArr(arr)+1));


// int MinStrArr (int[,] arr)
// {
//     int min;
//     int count=0;
//     int sum = 0;
//     int [] findMin = new int[arr.GetLength(0)];
//     for (int i = 0; i<arr.GetLength(0); i++)
//     {
//         for (int j = 0;j<arr.GetLength(1);j++)
//         {
//             sum+= arr[i,j];
//         }
//         findMin[i] = sum;
//         sum=0;
//     }
//     min = findMin[0];
//     for (int i =1; i<findMin.Length;i++ )
//     {
//         if (min > findMin[i])
//         {
//             min = findMin[i];
//             count=i;
//         }
//     }
//     return count;
// }

// int[,] GetArr(int a, int b)
// {
//     int[,] result = new int[a, b];
//     for (int i = 0; i < a; i++)
//     {
//         for (int j = 0; j < b; j++)
//         {
//             result[i, j] = new Random().Next(10);
//         }
//     }
//     return result;
// }

// void WriteArr (int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }


//номер 3 ---------- ЗАМЕНИЛ ЗАДАЧУ №58 НА РЕКОМЕНДОВАННУЮ

// Console.Write("введите размерность массива: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write(" ");
// int b = int.Parse(Console.ReadLine()!);


// int[,] arr = GetArr(a,b);
// WriteArr(arr);

// Console.WriteLine("Измененный массив: ");

// WriteArr(SortDecreaseArr(arr));

// int[,] SortDecreaseArr (int[,] arr)
// {
//     int temp;
//     for (int j = 1; j<arr.GetLength(1); j+=2)
//     {
//         for (int i = 0;i<arr.GetLength(0);i++) 
//         {
//             for (int h = i+1 ;h<arr.GetLength(0); h++) 
//             {
//                 if (arr[i,j] > arr[h,j])
//                 {
//                     temp = arr[i,j];
//                     arr[i,j] = arr[h,j];
//                     arr[h,j] = temp;
//                 }
//             }
//         }
//     }
//     return arr;
// }

// int[,] GetArr(int a, int b)
// {
//     int[,] result = new int[a, b];
//     for (int i = 0; i < a; i++)
//     {
//         for (int j = 0; j < b; j++)
//         {
//             result[i, j] = new Random().Next(10);
//         }
//     }
//     return result;
// }

// void WriteArr (int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }