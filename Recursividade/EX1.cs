//  Faça um programa que apresente um menu inicial com as seguintes opções:
//	MENU PRINCIPAL
//  1 – Funções sem vetor
//	2 – Funções com vetor
//	Digite a opção desejada:

//  Se o usuário escolher a opção 1, solicite um número inteiro inicial e um número inteiro final. Em seguida apresente um segundo menu com as seguintes opções:
//  MENU SECUNDÁRIO
//  1 - Inteiros em ordem crescente
//  2 - Inteiros em ordem decrescente
//  3 - Inteiros ímpares (crescente)
//  4 - Somatório dos inteiros
//  Faça uma função recursiva para cada opção desse segundo menu.

//  Se o usuário escolher a opção 2 (do menu inicial), solicite vários números inteiros (armazene num vetor) e em seguida faça uma função recursiva que calcule o somatório dos números do vetor.

void crescente(int ni, int nf)
{
    if (ni <= nf)
    {
        Console.WriteLine(ni);
        crescente(ni + 1, nf);
    }
}

void decrescente(int ni, int nf)
{
    if (nf >= ni)
    {
        Console.WriteLine(nf);
        decrescente(ni, nf - 1);
    }
}

static void impar(int ni, int nf)
{
    if (ni <= nf)
    {
        if (ni % 2 == 0)
        {
            impar(ni + 1, nf);
        }
        else
        {
            Console.WriteLine(ni);
            impar(ni + 1, nf);
        }
    }
}

static void somatoria(int ni, int nf)
{
    int soma = (ni + nf);
    Console.WriteLine(soma);
}

static void somatoria2(int[] vet)
{
    int f = Convert.ToInt32("1"), soma = 0;
    while (f <= 5)
    {
        soma = (soma + vet[f]);
        f = (f + 1);
    }
    Console.WriteLine(soma);
}


string op = "0", op2;
while (op != "3")
{
    Console.WriteLine("MENU PRINCIPAL");
    Console.WriteLine("1. Função sem vetor");
    Console.WriteLine("2. Função com vetor");
    Console.WriteLine("3. Sair");
    Console.Write("Escolha a opção desejada: ");
    op = Console.ReadLine();
    if (op == "1")
    {
        Console.Write("Informe o número inicial: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Informe o número final: ");
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("MENU SECUNDÁRIO");
        Console.WriteLine("1. Crescente");
        Console.WriteLine("2. Decrescente");
        Console.WriteLine("3. Ímpares");
        Console.WriteLine("4. Somatório");
        Console.Write("Escolha a opção desejada: ");
        op2 = Console.ReadLine();
        if (op2 == "1")
            crescente(n1, n2);
        else if (op2 == "2")
            decrescente(n1, n2);
        else if (op2 == "3")
            impar(n1, n2);
        else if (op2 == "4")
            somatoria(n1, n2);
    }
    else if (op == "2")
    {
        int[] som = new int[6];
        int i = Convert.ToInt32("1");
        while (i <= 5)
        {
            Console.Write("Insira um número: ");
            som[i] = Convert.ToInt32(Console.ReadLine());
            i = (i + 1);
        }
        somatoria2(som);
    }
}
