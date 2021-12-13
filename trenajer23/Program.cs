
void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int N = 100;
int count = 1;
void FillArray(double[,] matr)
{
    if (count < N)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                double A = count;
                double B = Math.Pow(A, 2);
                matr[i, j] = B;
                count++;
            }
        }
    }
}


double[,] matr = new double [15, 15];
PrintArray(matr);
Console.WriteLine();
FillArray(matr);
PrintArray(matr);

