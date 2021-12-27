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
        A[i] = new Random().Next(1, 10);
    }
}
void Finder(int[] A, int B)
{
    for (int i = 0; i < A.Length; i++)
    {
        if (A[i] == B)
        {
            Console.Write(i);
            Console.WriteLine();
            break;
        }
    }
}




int[] A = new int[10];
int B = 8;
FillArray(A);
PrintArray(A);
Finder(A, B);


