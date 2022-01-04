void FillArray(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[i, j] = new Random().Next(10,30);
        }
    }
}

void PrintArray(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            Console.Write($"{A[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Sum(int[,] A)
{
    int B = 0;
    int count = 0;
    int P = 0;

    for (int j = 0; j < A.GetLength(1); j++)
    {
        for (int i = 0; i < A.GetLength(0); i++)
        {
            B = B + A[i, j];
            count++;
        }
        B = B / count;
        P++;
        Console.WriteLine($"Столбец №{P} средняя арифметическая = {B}");
        B = 0;
        count = 0;
    }
}

int[,] A = new int[5, 5];
FillArray(A);
PrintArray(A);
Sum(A);