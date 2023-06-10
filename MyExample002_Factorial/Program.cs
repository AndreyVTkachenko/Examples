// Нахождение факториала числа, вводимого пользователем

Console.Write("Введите число для нахождения факториала ");

int N = Console.Read();
int F = 1;

if(N>1)
{
    F = F*N;
    N = N - 1;
}
Console.WriteLine(F);
