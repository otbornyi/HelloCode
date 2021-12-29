void PrintArray(double[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        Console.Write($"{A[i]} ");
    }
    Console.WriteLine();
}

void FillArray(double[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        A[i] = new Random().Next(1, 10);
    }
}

double FindMax(double[] A)
{
    double result = 0;    
    for (int i = 0; i < A.Length; i++)
    {
        if(A[i] > result)
        {
            result = A[i];
        }
    }
    Console.WriteLine(result);
    return result;
}


double[] A = new double[6];
FillArray(A);
PrintArray(A);
FindMax(A);

