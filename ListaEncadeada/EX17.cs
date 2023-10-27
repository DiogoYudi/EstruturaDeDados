//17) Faça uma implementação que construa uma lista encadeada. Seu programa deve ter as opções de inserção e remoção dos elementos. 
//Após remover um elemento da lista, exiba-o na tela.﻿

void Insere(ref tp_no l)
{
    Console.Write("Informe o número a ser inserido: ");
    int n = Convert.ToInt32(Console.ReadLine());
    tp_no no = new tp_no();
    no.a = n;
    if (l != null)
        no.prox = l;
    l = no;
}

tp_no Remove(ref tp_no l)
{
    tp_no no = null;
    if (l != null)
    {
        no = l;
        l = l.prox;
        no.prox = null;
    }
    return no;
}

tp_no lista = null;
int op;
int menu()
{   Console.WriteLine("MENU");
    Console.WriteLine("1. Inserir dados");
    Console.WriteLine("2. Excluir dados");
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
            Insere(ref lista);
            break;
        case 2:
            tp_no v = Remove(ref lista);
            Console.WriteLine("Número removido = "+v.a);   
            break;
    }
}

class tp_no
{
    public int a;
    public tp_no prox;
}
