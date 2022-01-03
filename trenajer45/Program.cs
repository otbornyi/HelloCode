int A = 0;
Console.Write($"{A} ");
int B = 1;
Console.Write($"{B} ");
void FillArray(int[] Z)
{
    for (int i = 0; i < Z.Length; i++)
    {
        int C = A + B;
        Z[i] = C;
        A = B;
        B = C;
    }
}

void PrintArray(int[] Z)
{
    for (int i = 0; i < Z.Length; i++)
    {
        Console.Write($"{Z[i]} ");
    }
}

int[] Z = new int[20];
FillArray(Z);
PrintArray(Z);

// Нахождение фибонначи.