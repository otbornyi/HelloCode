void PrintArray(int[] A)
{
    for(int i = 0; i < A.Length; i++)
    {
        Console.Write($"{A[i]} ");
       
    }
}
void FillArray(int[] A)
{
    int i = 0;
    while( i < A.Length)
    {
        A[i] = new Random().Next(1,10);
        i++;
    }
}


int[] B = new int [10];
PrintArray(B);
Console.WriteLine();
FillArray(B);
PrintArray(B);