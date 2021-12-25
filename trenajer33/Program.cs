void FillArray(int[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        A[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        Console.Write($"{A[i]} ");
    }
    Console.WriteLine();
}

void request(int[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        A[i] = -A[i];
    }
}

int[] A = new int[10];
FillArray(A);
PrintArray(A);
request(A);
PrintArray(A);