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

void FillArray(int[,] A)
{
    int Z = 1;
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[i, j] = Z * 2;
            Z++;
        }
    }
}
int[,] A = new int [3,3];
FillArray(A);
PrintArray(A);