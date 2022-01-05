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

void SortArray(int[,] A)
{
    int i = 0;
    int j = 0;
    int lastInd = A.GetLength(1) - 1;
    while (i < A.GetLength(0))
    {
        int p = lastInd;
        while (p > 0)
        {
            int min = A[i, p];
            while (j < p)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    A[i, j] = A[i, p];
                    A[i, p] = min;
                }
                j++;
            }
            p = p - 1;
            j = 0;
        }
        p = lastInd;
        j = 0;
        i++;
    }
}


int[,] A = new int[4, 4];
FillArray(A);
PrintArray(A);
SortArray(A);
PrintArray(A);

//Упорядочивание элементов массива по убыванию.