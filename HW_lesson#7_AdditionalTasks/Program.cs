// // 1-st Addition Task

// Console.WriteLine("Введите размерность 3D массива");
// Console.Write("Введите размер а: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите размер b: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите размер c: ");
// int c = int.Parse(Console.ReadLine()!);

// WriteArr3D (RemovingRepetitions (a, b, c,
//                                 GetArr3D (a, b, c)));


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


// // немного перевыполню задачу и для красоты спирально заполню любой массив квадратного размера и числами начиная со 100
// // на листочке находил закономерности,так что имею право :D
// //Читать код достаточно сложно, уже делаю эту задачу второй или даже четвертый час, так что в моментах просто методом перебора делал действия))
// // НО ЭТО ЧЕРТ ВОЗЬМИ РАБОАТЕТ!!! С ЛЮБЫМ РАЗМЕРОМ МАССИВА
// Console.Write("Введите размер стороны квадратного массива (четное число): ");
// int size = int.Parse(Console.ReadLine()!);
// int[,] arr = new int [size,size];

// // заполним первую строку массива
// for (int i =0; i<size; i++)
// {
//     arr[0,i]=100 + i;
// }

// // а дальше магия)
// int line = 0;
// int col = size-1;
// int HelpI = size-1;
// int HelpJ = size;
// int count = size/2;
// int current = arr[0,size-1] +1; // потому что  первая строка массива заполнена. Это актуальное число
// while (count>0)
// {
//     for (int i = line+1; i<=HelpI; i++){
//         arr[i,col] = current;
//         current++;
//         line = i;
//     }
//     for (int j = col-1; j>=size-HelpJ; j--){
//         arr[line,j] = current;
//         current++;
//         col=j;
//     }
//     HelpJ-=2;
//     for (int i = line-1; i>=size-HelpI; i--){
//         arr[i,col] = current;
//         current++;
//         line = i;
//     }
//     for (int j = col + 1;j<=HelpJ;j++){
//         arr[line,j] = current;
//         current++;
//         col=j;
//     }
//     HelpJ++;
//     HelpI--;
//     count--;;
// }

// // вывод массива
// for (int i =0;i<size;i++)
// {
//     for (int j=0;j<size;j++)
//     {
//         Console.Write($"{arr[i,j]} ");
//     }
//     Console.WriteLine();
// }

// // Очень устал, но доволен своей работой :3