void FillArray(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[i, j] = new Random().Next(10, 30);
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
    Console.WriteLine();
}

void SwapArray(int[,] A)
{
    int first = A.GetLength(0);
    int second = A.GetLength(1);
    int i = 0;
    int j = 0;
    while(j < second)
    {
        int Save = A[i, j];
        A[i,j] = A[(first - 1), j];
        A[(first - 1), j] = Save;
        j++;
    }  
}
int[,] A = new int[4, 4];
FillArray(A);
PrintArray(A);

SwapArray(A);
PrintArray(A);