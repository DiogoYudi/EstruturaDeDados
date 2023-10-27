//6) Defina uma função recursiva que converte um número inteiro para a base binária.

int binario(int n)
{
    if (n == 0 || n == 1)
        return n;
    else
        return (n % 2 + (10*binario(n/2))) ;
}

Console.Write("Insira um número para a conversão em binário: ");
int z = Convert.ToInt32(Console.ReadLine());
int bin = binario(z);
Console.WriteLine(bin);
