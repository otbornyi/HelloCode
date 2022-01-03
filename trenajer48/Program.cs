void FillArray(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[i, j] = new Random().Next(10, 100);
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

void returnArray(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            if(A[i, j] % 2 == 0)
            {
                A[i, j] = -(A[i, j]);
            }
        }
        
    }
}

int[,] A = new int [3, 3];
FillArray(A);
PrintArray(A);
returnArray(A);
PrintArray(A);