// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = ReadNum("Введите число M: ");
int N = ReadNum("Введите число N: ");
int sum = 0;

int ReadNum(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

SumNumbers();

void SumNumbers()
{
    if (M < N)
    {
        while (M < N + 1)
        {
            sum = sum + M;
            M = M + 1;
        }
    }

    else
    {
        while (N < M + 1)
        {
            sum = sum + N;
            N = N + 1;
        }
    }
    Console.WriteLine(sum);
}
