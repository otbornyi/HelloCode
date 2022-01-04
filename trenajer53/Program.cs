void FillArray(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[i, j] = new Random().Next(10, 40);
        }
    }
}
void PrintArray(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            Console.Write($"{A[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FindNumbers(int[,] A)
{
    Console.Write("Введите число : ");
    int number = int.Parse(Console.ReadLine());
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            if(A[i, j] == number)
            {
                Console.Write($"Данное число встречается в массиве в позициии {i}, {j}");
                Console.WriteLine();
            }
        }
    }
}
int[,] A = new int[4, 5];
FillArray(A);
PrintArray(A);
FindNumbers(A);