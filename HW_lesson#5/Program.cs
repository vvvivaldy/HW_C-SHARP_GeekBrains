// //task 1
// int[] randarr = GetRandomArr();
// Console.WriteLine($"Массив с рандомными трёхзначными числами: [{String.Join(", ", randarr)}], колличество четных чисел: {even_numbers(randarr)}");
// int[] GetRandomArr()
// {
//     int[] result = new int[15];
//     for (int i=0; i<15;i++)
//     {
//         result[i] = new Random().Next(100,1000);
//     }
//     return result;
// }
// int even_numbers (int[] arr)
// {
//     int result = 0;
//     for (int i=0; i<15;i++)
//     {
//         if (arr[i] % 2 == 0) result++;
//     }
//     return result;
// }


// //task 2
// int quantity = new Random().Next(1, 10);
// int[] randarr = GetRandomArr(quantity);
// Console.WriteLine($"Kолличество элементов в массиве: {quantity}");
// Console.WriteLine($"Массив с рандомными числами: [{String.Join(", ", randarr)}], сумма чисел на нечетных позициях: {sum_uneven(randarr)}");
// int[] GetRandomArr(int quan)
// {
//     int[] result = new int[quan];
//     for (int i=0; i<quan;i++)
//     {
//         result[i] = new Random().Next(20);
//     }
//     return result;
// }
// int sum_uneven (int[] arr)
// {
//     int result = 0;
//     for (int i = 0; i<arr.Length; i++)
//     {
//         if (i%2 != 0)
//         {
//             result+= arr[i];
//         }
//     }
//     return result;
// }


// //task 3
// int quantity = new Random().Next(2, 11);
// int[] randarr = GetRandomArr(quantity);
// Console.WriteLine($"Kолличество элементов в массиве: {quantity}");
// Console.WriteLine($"Массив с рандомными вещественными числами: [{String.Join(", ", randarr)}], разница между максимальным и минимальным элементов массива: {MaxValue(randarr)-MinValue(randarr)}");
// int[] GetRandomArr(int quan)
// {
//     int[] result = new int[quan];
//     for (int i=0; i<quan;i++)
//     {
//         result[i] = new Random().Next(-100, 101);
//     }
//     return result;
// }
// int MaxValue (int[] arr)
// {
//     int MaxValue = arr[0];

//     for (int i = 1; i<arr.Length; i++)
//     {
//         if (arr[i] > MaxValue)
//         {
//             MaxValue = arr[i];
//         }
//     }
//     return MaxValue;
// }
// int MinValue (int[] arr)
// {
//     int MinValue = arr[0];

//     for (int i = 1; i<arr.Length; i++)
//     {
//         if (arr[i] < MinValue)
//         {
//             MinValue = arr[i];
//         }
//     }
//     return MinValue;
// }




