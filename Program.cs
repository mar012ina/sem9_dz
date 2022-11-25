// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1.  Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 1;

void NumbersBack(int num, int count)
{
    if (count > num) return;
    else
    {
        NumbersBack(num, count + 1);
        Console.Write(count + " ");
    }
}

NumbersBack(num, count);


// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumRangeNumbers(int M, int N)
{
    int sum = 0;
    if(N == M) return 0;
    else 
    {
        M++;
        sum = M + SumRangeNumbers(M,N);
        return sum;
    }
}
Console.WriteLine($"Сумма чисел от {M} до {N} равна: {SumRangeNumbers(M - 1, N)}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Akkerman(int M, int N)
{
    if (M == 0) return N + 1;
    else if (N == 0 && M > 0) return Akkerman(M - 1, 1);
    else return (Akkerman(M - 1, Akkerman(M, N - 1)));
}

Console.WriteLine($"{Akkerman(M,N)}");