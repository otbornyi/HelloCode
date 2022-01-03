void FillArray(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[i, j] = new Random().Next(10,40);
        }
    }
}
void PrintArray(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            Console.Write($"{A[i, j]}   ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

int[,] A = new int[3, 8];
FillArray(A);
PrintArray(A);

// Заполнение двумерного массива.
