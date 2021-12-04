Console.WriteLine("Условие : ");
Console.WriteLine("Проверить истинность выражения !(X || Y) == (!X && !Y) ");
bool X, Y;
bool result = true;
bool TrueFalse(bool X, bool Y)
{
    return !(X || Y) == (!X && !Y);
}

X = true;
Y = true;
bool A1 = TrueFalse(X, Y); Console.Write("Пара А1 - "); Console.WriteLine(A1);
if(result == A1)

X = true;
Y = false;
bool A2 = TrueFalse(X, Y); Console.Write("Пара А2 - "); Console.WriteLine(A2);
if(result == A2)

X = false;
Y = true;
bool A3 = TrueFalse(X, Y); Console.Write("Пара А3 - "); Console.WriteLine(A3);
if(result == A3)

X = false;
Y = false;
bool A4 = TrueFalse(X, Y); Console.Write("Пара А4 - "); Console.WriteLine(A4);
if(result == A4)
{
    Console.Write("Общий результат - ");
    Console.WriteLine(result);
}


























