void PrintArray(int[] A)
{
    for(int i = 0; i < A.Length; i++)
    {
        Console.Write($"{A[i]} ");
    }
    Console.WriteLine();
}

void FillArray(int[] A)
{
    for(int i = 0; i < A.Length; i++)
    {
        A[i] = new Random().Next(-10, 10);
    }
}

void Search(int[] A)
{
    int Z = 0;
    int M = 0;
    for (int i = 0; i < A.Length; i++)
    {
        if (A[i] > 0)
        {
            Z = Z + A[i];
        }
        else
        {
            M = M + A[i];
        }
    }
    Console.Write("Сумма положительных элементов массива = ");
    Console.WriteLine($"({Z})");
    Console.Write("Сумма отрицательных элементов массива = ");
    Console.WriteLine($"({M})");
}



int[] A = new int [12];
FillArray(A);
PrintArray(A);
Search(A);