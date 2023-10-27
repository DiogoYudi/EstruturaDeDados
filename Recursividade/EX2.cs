//2) Escreva uma função recursiva chamada potencia(x, y), que retorne a base x elevado ao expoente y.

int potencia(int x, int y)
{
    if (y == 0)
        return 1;
    else
        return x * potencia(x, y - 1);
}


Console.Write("Infome o número da base: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o expoente: ");
int e = Convert.ToInt32(Console.ReadLine());
int res = potencia(b, e);
Console.Write("Potência = ");
Console.WriteLine(res);
