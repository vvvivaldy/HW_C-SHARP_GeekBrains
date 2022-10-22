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


