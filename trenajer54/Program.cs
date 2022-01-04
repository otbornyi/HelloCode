void FillArray(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[i, j] = new Random().Next(10, 40);
        }
    }
}

void PrintArray(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            Console.Write($"{A[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] A = new int[4, 4];
FillArray(A);
PrintArray(A);
int B = 0;
for (int i = 0; i < A.GetLength(0); i++)
{
    for (int j = 0; j < A.GetLength(1); j++)
    {
        if(i == j)
        {
            B = B + A[i, j];
        }
    }
}
Console.WriteLine(B);

// Вычисление главной диагонали цифровой матрицы.