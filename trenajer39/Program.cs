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
        A[i] = i + 1;
    }
}

void FindSum(int[] A)
{
    int Sum = 1;
    int n = 1;
    for (int j = 0; j < A.Length / 2; j++)
    {
        
            for (int i = 0; i < A.Length / 2; i++)
            {
                if(i != A.Length / 2)
                {
                Sum = Sum * A[i] * A[A.Length - n];
                Console.WriteLine(Sum);
                Sum = 1;
                n++;
                }
                else
                {
                    Console.WriteLine(A[i]);
                }
                }
                break;
        
        break;
    }
}
 int[] A = new int[7];
 FillArray(A);
 PrintArray(A);
 FindSum(A);