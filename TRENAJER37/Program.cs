void PrintArray(int[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        Console.Write($"{A[i]} ");
    }
    Console.WriteLine();
}

void Find(int[] A)
{

    int count = 0;
    for (int i = 0; i < A.Length; i++)
    {
        if(A[i] < 100 && A[i] > 9)
        {
            count = count + 1;
        }
    }
    Console.WriteLine(count);
}
void FillArray(int[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        A[i] = i + 1;
    }
}

int[] A = new int[123];
FillArray(A);
PrintArray(A);
Find(A);