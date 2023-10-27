//4) Baseado no algoritmo de Euclides, implemente uma função recursiva para determinar o máximo divisor comum (mdc) entre dois números inteiros x e y.
//	Algoritmo de Euclides:
//	se (x = y) retorna x
//	senão se (x < y) retorna mdc(y, x)
//	senão retorna mdc(x - y, y)

int mdc(int x, int y)
{ 

    if (x == y)
        return x;

    else if (x < y)
        return mdc(y, x);
        
    else
        return mdc(x - y, y);
}

Console.Write("Escolha o número de x = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Escolha o número de y = ");
int b = Convert.ToInt32(Console.ReadLine());
int md = mdc(a, b);
Console.WriteLine("MDC = " + md);
