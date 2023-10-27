//5) A Série de Fibonacci pode ser definida da seguinte maneira:
//	se (n == 0 ou n == 1) retorna n
//	se (n >= 2) retorna fib(n – 1) + fib(n – 2)
//  Seja fib(n) uma função que retorna o n-ésimo termo da série de Fibonacci, 
//  implemente uma versão recursiva e outra iterativa. Observe que a partir de um 
//  determinado número, a função recursiva começa a ficar mais lenta que a iterativa.

int fibonacci(int n)
{
    if (n <= 1)
        return n;
    else
        return fibonacci(n - 1) + fibonacci(n - 2);
}

Console.Write("Escolha um número: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(fibonacci(z));
