void PrintArray(int[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        Console.Write($"{A[i]} ");
    }
    Console.WriteLine();
}
void FillArray(int[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        A[i] = new Random().Next(1, 100);
    }
}

void FindSum(int[] A)
{
    int Sum = 0;
    for (int i = 0; i < A.Length; i++)
    {
        if(i % 2 == 0)
        {
Sum = Sum;
        }
        else
        {
            Sum = Sum + A[i];
        }
    }
    Console.WriteLine(Sum);
}


int[] A = new int[10];
FillArray(A);
PrintArray(A);
FindSum(A);