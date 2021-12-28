void PrintArray(int[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        Console.WriteLine($"{A[i]} ");
    }
}

void FillArray(int[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        A[i] = new Random().Next(100, 999);
    }
}

void FindEvenOdd(int[] A)
{
    int B = 0;
    int C = 0;
    for (int i = 0; i < A.Length; i++)
    {
        if (A[i] % 2 == 0)
        {
            B = B + 1;
        }
        else
        {
            C = C + 1;
        }
    }
    Console.WriteLine($"Четных чисел - {B}");
    Console.WriteLine($"Нечетных чисел - {C}");
}

int[] A = new int[6];
FillArray(A);
PrintArray(A);
FindEvenOdd(A);