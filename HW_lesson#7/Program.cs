// //task 1
// Console.Write("Введите размерность массива (стороки): ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Введите размерность массива (столбцы): ");
// int n = int.Parse(Console.ReadLine()!);

// double[,] Array = GetArray(m,n);
// PrintArray(Array);

// double[,] GetArray(int m, int n)
// {
//     double[,] result = new double[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j<n; j++)
//         {
//             result[i,j] = new Random().NextDouble();
//             result[i,j] += new Random().Next(-20,21);
//         }
//     }
//     return result;
// }

// void PrintArray (double[,] Array)
// {
//     for (int i =0;i<Array.GetLength(0);i++)
//     {
//         for (int j =0;j<Array.GetLength(1);j++)
//         {
//             Console.Write($"{(Array[i,j]):f1} ");
//         }
//         Console.WriteLine();
//     }
// }



// // task 2
// //ввод позиции элемента
// Console.Write("Введите строку элемента: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Введите столбец элемента: ");
// int n = int.Parse(Console.ReadLine()!);
// // создание массива и его вывод
// double[,] Array = GetArray();
// PrintArray(Array);
// Console.WriteLine();

// // условие допустимых значений, пишу не более 11 т.к. комп считает с 0,а мы с 1 => для человека существует строка и столб 10, а для компа нет
// if (m > 11 || n > 11)
// {
//     Console.WriteLine("Такого элемента нет");
// }
// else {
//     // пишу m-1 и n-1 т.к. комп считает с 0, а мы с 1
//     Console.WriteLine(Array[m-1,n-1]);
// }

// //функции
// double[,] GetArray()
// {
//     double[,] result = new double[10,10];
//     for (int i = 0; i < 10; i++)
//     {
//         for (int j = 0; j<10; j++)
//         {
//             result[i,j] = new Random().Next(21);
//         }
//     }
//     return result;
// }
// void PrintArray (double[,] Array)
// {
//     for (int i =0;i<Array.GetLength(0);i++)
//     {
//         for (int j =0;j<Array.GetLength(1);j++)
//         {
//             Console.Write($"{Array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }



// //task 3
// //ввод данных
// Console.Write("Введите размерность массива (стороки): ");
// int line = int.Parse(Console.ReadLine()!);
// Console.Write("Введите размерность массива (столбцы): ");
// int col = int.Parse(Console.ReadLine()!);

// int[,] arr = GetArray(line, col);

// // вывод данных
// PrintArray(arr);
// Console.WriteLine();
// double[] arithmeticMEAN = Get_arithmetic_mean(arr, line, col); 
// Console.WriteLine($"Среднее арифметическое столбцов: {String.Join("; ", arithmeticMEAN)}");



// // функции
// int[,] GetArray(int line, int col)
// {
//     int[,] result = new int[line,col];
//     for (int i = 0; i < line; i++)
//     {
//         for (int j = 0; j<col; j++)
//         {
//             result[i,j] = new Random().Next(0,11);
//         }
//     }
//     return result;
// }
// void PrintArray (int[,] Array)
// {
//     for (int i =0;i<Array.GetLength(0);i++)
//     {
//         for (int j =0;j<Array.GetLength(1);j++)
//         {
//             Console.Write($"{Array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// double[] Get_arithmetic_mean (int[,] Arr, int line, int column)
// {
//     double[] result = new double[column];
//     for (int j = 0; j<column; j++)
//     {
//         for (int i=0;i<line;i++)
//         {
//             result[j] += Arr[i,j];
//         }
//         result[j] /= line;
//         Math.Floor(result[j]);
//     }
//     return result;
// }