//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ListNaturalNumbers(int n)
{
    if (n == 0) return;
    System.Console.WriteLine(n);
    ListNaturalNumbers(n - 1);
}
// end of void 

// в этом коде не буду тратить время на ввод пользователем  N, проверку натуральности N, красоту вывода в строку

System.Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1");

int number = 5;
ListNaturalNumbers(number);


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

void SumNaturalNumbers(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (m++);
    SumNaturalNumbers(m, n, sum);
}
// end of void

//// в этом коде не буду тратить время на ввод пользователем M,N , проверку, что M<N
System.Console.WriteLine();
System.Console.WriteLine("Задача 66:Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
int mStart = 1;
int nFinish = 15;
int sum =0;
SumNaturalNumbers(mStart, nFinish, sum);


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akerman(int n, int m)
{
    if (n == 0) return m + 1;
    else
        if ((n != 0) && (m == 0)) return Akerman(n - 1, 1);
        else return Akerman(n - 1, Akerman(n, m - 1));
}
// end of void



//// в этом коде не буду тратить время на ввод пользователем M,N , проверку, их не отрицательности


System.Console.WriteLine();
System.Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");

int n = 2;
int m = 3;

System.Console.WriteLine($" значение функции Аккермана от {n} и {m} =  {Akerman(n, m)}");