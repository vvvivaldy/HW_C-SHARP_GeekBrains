// // task 1

// Console.Write("Введите колличество чисел в массиве: ");
// int M = int.Parse(Console.ReadLine()!);
// int[] arr = new int[M];

// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write($"Введите {i+1}-ый элемент массива: ");
//     int a = int.Parse(Console.ReadLine()!);
//     arr[i] = a;
// }

// Console.Write($"Вы ввели --{CountMoreNull(arr)}-- чисел/ла больше 0");


// int CountMoreNull(int[] arr)
// {
//     int result = 0;
//     for (int i = 0; i<arr.Length; i++)
//     {
//         if (arr[i] > 0)
//         {
//             result++;
//         }
//     }
//     return result;
// }



// // task 2
// // формула нахождения x(общий) = (b2-b1)/(k1-k2)
// // y = x(общий)*k1 + b1
// // ввод данных
// Console.WriteLine("Нахождения точки персечения функций вида y = kx + b");
// Console.Write("Введите k1: ");
// double k1 = double.Parse(Console.ReadLine()!);
// Console.Write("Введите b1: ");
// double b1 = double.Parse(Console.ReadLine()!);
// Console.Write("Введите k2: ");
// double k2 = double.Parse(Console.ReadLine()!);
// Console.Write("Введите b2: ");
// double b2 = double.Parse(Console.ReadLine()!);

// // расчетная часть и вывод
// double x = (b2-b1)/(k1-k2);
// double y = x*k1 + b1;

// Console.WriteLine($"Точка пересечений будет в координате ({x}, {y})");
