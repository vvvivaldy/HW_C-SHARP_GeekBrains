// //task 1

// Console.WriteLine("Введите значение N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(PrintNum(n,1));

// string PrintNum(int start, int end)
// {
//     if (start == end) return ("1");
//     return (start + ", " + PrintNum(start - 1, end));
// }

// // task 2 
// Console.WriteLine("Введите начальное значение M: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите конечное значение N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(SumNum(m,n));

// int SumNum(int start, int end)
// {
//     if (start == end) return start;
//     return start + SumNum(start + 1, end);
// }


// // task 3

// Console.WriteLine("Введите первое значение M: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе значение N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine("А(M,N): " + fAkk(m,n));
// int fAkk(int m, int n)
// {
//     if (m==0) return n+1;
//     else if ((m!=0)&&(n == 0)) return fAkk(m-1,1);
//     return fAkk(m-1, fAkk(m,n-1));
// }
