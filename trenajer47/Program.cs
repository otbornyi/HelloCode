void FillArray(double[,] Double)
{
    for (int i = 0; i < Double.GetLength(0); i++)
    {
        for (int j = 0; j < Double.GetLength(1); j++)
        {
            Double[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(double[,] Double)
{
    for (int i = 0; i < Double.GetLength(0); i++)
    {
        for (int j = 0; j < Double.GetLength(1); j++)
        {
            Console.Write($"{Double[i, j]}  ");
        }
        Console.WriteLine();
    }
}

double[,] Double = new double [3, 3];
FillArray(Double);
PrintArray(Double);