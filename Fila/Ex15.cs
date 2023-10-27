//15) Escreva um programa que simule o controle de uma pista de decolagem de aviões em um aeroporto. Os aviões são identificados pelos números digitados pelo usuário. Neste programa, o usuário deve ser capaz de realizar as seguintes operações:

//a) Adicionar vários aviões à fila de espera para decolagem

//b) Consultar a quantidade de aviões aguardando na fila

//c) Autorizar a decolagem de um avião da fila

//d) Listar os números de todos os aviões na fila

//e) Consultar o número do primeiro avião da fila

//Construa um menu principal para oferecer essas operações ao usuário.

const int MAX = 20;

void Insere(int[] p, int na, ref int f)
{
    p[f] = na;
    f++;
}

int Remove(int[] p, ref int i)
{
    i++;
    return (p[i]);
}

void adicionar(int[] p, ref int i, ref int f)
{
    Console.Write("Digite o número do avião: ");
    int na = Convert.ToInt32(Console.ReadLine());
    Insere(p, na, ref f);
}

void consultar(int i, int f)
{
    Console.WriteLine(f - i);
}

void autorizar(int[] p, ref int i)
{
    Remove(p, ref i);
}

void apresentar(int[] p, int i, int f)
{
    while (i < f)
    {
        Console.WriteLine(p[i]);
        i++;
    }
}

void consultar1(int[] p, int i)
{
    Console.WriteLine(p[i]);
}

int[] p = new int[MAX];
int i = 0, f = 0, op;

int menu()
{   Console.WriteLine("MENU");
    Console.WriteLine("1. Adicionar um avião à fila");
    Console.WriteLine("2. Consultar a quantidade de aviões");
    Console.WriteLine("3. Autorizar a decolagem de avião");
    Console.WriteLine("4. Apresentar os aviões presente na fila");
    Console.WriteLine("5. Consultar o número do primeiro avião na fila");
    Console.WriteLine("0. Sair");
    Console.Write("Escolha uma opção: ");
    int op = Convert.ToInt32(Console.ReadLine());
    return op;
}
while ((op = menu()) != 0)
{
    switch (op)
    {
        case 1:
            adicionar(p, ref i, ref f);
            break;
        case 2:
            consultar(i, f);
            break;
        case 3:
            autorizar(p, ref i);
            break;
        case 4:
            apresentar(p, i, f);
            break;
        case 5:
            consultar1(p, i);
            break;
    }

}
