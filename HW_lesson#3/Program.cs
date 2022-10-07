// // task 1
// Console.WriteLine("Число для проверки на поллиндромность: " );
// int n = int.Parse(Console.ReadLine()!);
// int num = n;
// int res = 0;
// int ostatok = 0;
// while (n > 0)
// {
//     ostatok = n%10;
//     //res записывает изначальное число в обратном порядке. то есть первую цифру числа ostatok
//     // из разряда единиц превращает в старший разряд и т.д.
//     res = res*10 + ostatok;
//     // убираем число, которое мы записали в остаток
//     n = n/10;
// }

// // выводим результат

// if (num == res)
// {
//     Console.WriteLine("Это поллиндром!");
// }
// else
// {
//     Console.WriteLine("Это не поллиндром :(");
// }




// //task 2
// Console.WriteLine("Введите поочередно координаты точек А и В");
// Console.WriteLine("Введите координату Xa");
// int Xa = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Ya");
// int Ya = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Za");
// int Za = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Xb");
// int Xb = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Yb");
// int Yb = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Zb");
// int Zb = int.Parse(Console.ReadLine()!);

// double Result = Math.Sqrt( Math.Pow((Xb-Xa),2) + Math.Pow((Yb-Ya),2) +Math.Pow((Zb-Za),2) );

// Console.WriteLine($"Расстояние между точками А и В = {Result:f2}");



// //task 3
// Console.Write("Введите число, до которого вы хотите видеть кубы: ");
// int N = int.Parse(Console.ReadLine()!);
// int res;
// for (int i = 1; i <= N; i++)
// {
//     res = i * i * i;
//     if (i < N)
//     {
//         Console.Write(res + ", ");
//     }
//     else if (i == N)
//     {
//         Console.WriteLine(res);
//     }
// }