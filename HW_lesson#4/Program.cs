// // task 1
// Console.WriteLine("Введите число которое хотите возвести в степень: ");
// int num = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число,означающее степень: ");
// int degree = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Результат: {NumDegree(num, degree)}");
// // задачка работает даже 0^0=1)))))

// int NumDegree (int num, int deg)
// {
//     int result = 1;
//     for (int i=1; i <=deg; i++)
//     {
//         result *= num;
//     }
//     return result;
// }

// // task 2
// Console.WriteLine("Введите число сумму цифр которно хотите найти: ");
// String num = Console.ReadLine();
// Console.WriteLine($"Результат: {SumFigure(num)}");
// // София, не ругаися, по факту же методом сделал :D
// int SumFigure (String num)
// {
//     int result = 0;
//     int num2 = Convert.ToInt32(num);
//     for (int i = 0; i < num.Length; i++) 
//     {
//         result += num2%10;
//         num2 /= 10;
//     }
//     return result;
// }



// // task 3
// Console.WriteLine($"Массив с рандомными числами от 0 до 100: [{String.Join(", " , GetRandomArr())}]");
// //создаем метод, который может вывести массив
// int[] GetRandomArr()
// {
//     int[] result = new int[8];
//     for (int i=0; i<8;i++)
//     {
//         result[i] = new Random().Next(101);
//     }
//     return result;
// }



// //Объясняю принцип функции с void
// Console.Write("Введите колличество элементов в массиве: ");
// int ArrSize = int.Parse(Console.ReadLine()!);

// Console.Write("Введите минимальное число диапазона заполнения массива: ");
// int Min = int.Parse(Console.ReadLine()!);

// Console.Write("Введите максимальное число диапазона заполнения массива: ");
// int Max = int.Parse(Console.ReadLine()!);

// Arr(ArrSize, Min, Max);

// void Arr(int size, int a, int b)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(a, b + 1);
//     }
//     Console.WriteLine($"Вот ваш массив: [{String.Join(", ", result)}]");
// }