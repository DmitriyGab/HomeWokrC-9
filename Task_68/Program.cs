// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int n = 2;
// int m = 3;

double m = ReadNum("Введите число M: ");
double n = ReadNum("Введите число N: ");

if (m >= 0 && n >= 0)
{
    if (m < n)
    {
        akkerman(n, m);
    }
    else
    {
        akkerman(m, n);
    }
}

else Console.WriteLine("Введите неотрицательное число");

double result = akkerman(n, m);
Console.WriteLine(result);

double ReadNum (string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

double akkerman(double n, double m)
{
    if (n == 0)
    {
        return m + 1;
    }

    if (m == 0 && n > 0)
    {
        return akkerman(n - 1, 1);
    }
    return akkerman(n - 1, akkerman(n, m - 1));
}