void FillArray(double[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[i, j] = new Random().Next(10, 30);
        }
    }
}


void PrintArray(double[,] A)
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

void returnArray(double[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                A[i, j] = Math.Pow(A[i, j], 2);
            }
        }
    }
}

double[,] A = new double[4, 4];
FillArray(A);
PrintArray(A);
returnArray(A);
PrintArray(A);


// Если оба индекса, показать их квадраты.
