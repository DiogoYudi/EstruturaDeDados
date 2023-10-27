//24) Desenvolva um programa para inserir, pesquisar, remover e exibir os valores de uma árvore binária. Observe as opções a seguir:
//a) Inserir um valor digitado pelo usuário
//b) Pesquisar um valor digitado pelo usuário. Exiba uma mensagem informando se encontrou ou não
//c) Remover um valor digitado pelo usuário. Exiba a mensagem se removido com sucesso ou não encontrado
//d) Exibir todos os valores da árvore em ordem, pré ordem ou pós ordem

void Insere(ref tp_no r, int x)
{
    if (r == null)
    {
        r = new tp_no();
        r.valor = x;
    }
    else if (x < r.valor)
        Insere(ref r.esq, x);
    else
        Insere(ref r.dir, x);
}

tp_no Busca(tp_no r, int x)
{
    if (r == null)
        return null;
    else if (x == r.valor)
        return r;
    else if (x < r.valor)
        return Busca(r.esq, x);
    else
        return Busca(r.dir, x);
}

tp_no RetornaMaior(ref tp_no r)
{
    if (r.dir == null)
    {
        tp_no p = r;
        r = r.esq;
        return p;
    }
    else
        return RetornaMaior(ref r.dir);
}

tp_no Remove(ref tp_no r, int x)
{
    if (r == null)
        return null;
    else if (x == r.valor)
    {
        tp_no p = r;
        if (r.esq == null)
            r = r.dir;
        else if (r.dir == null)
            r = r.esq;
        else
        {
            p = RetornaMaior(ref r.esq);
            r.valor = p.valor;
        }
        return p;
    }
    else if (x < r.valor)
        return Remove(ref r.esq, x);
    else
        return Remove(ref r.dir, x);
}

void EmOrdem(tp_no r)
{
    if (r != null)
    {
        EmOrdem(r.esq);
        Console.WriteLine(r.valor);
        EmOrdem(r.dir);
    }
}

void PreOrdem(tp_no r)
{
    if (r != null)
    {
        Console.WriteLine(r.valor);
        PreOrdem(r.esq);
        PreOrdem(r.dir);
    }
}

void PosOrdem(tp_no r)
{
    if (r != null)
    {
        PosOrdem(r.esq);
        PosOrdem(r.dir);
        Console.WriteLine(r.valor);
    }
}

tp_no lista = null;
int op;
int menu()
{   Console.WriteLine("MENU");
    Console.WriteLine("1. Inserir valor");
    Console.WriteLine("2. Encontrar dado");
    Console.WriteLine("3. Remover valor");
    Console.WriteLine("4. Exibir valores em ordem");
    Console.WriteLine("5. Exibir valores em pré-ordem");
    Console.WriteLine("6. Exibir valores em pós-ordem");
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
            Console.WriteLine("Digite um valor para adicionar: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Insere(ref lista, x);
            break;
        case 2:
            Console.WriteLine("Digite o valor a ser buscado: ");
            int b = Convert.ToInt32(Console.ReadLine());
            tp_no rb = Busca(lista, b);
            if (rb == null)
                Console.WriteLine("Não encontrado");
            else
                Console.WriteLine("Encontrado");
            break;
        case 3:
            Console.WriteLine("Digite o valor para a remoção: ");
            int v = Convert.ToInt32(Console.ReadLine());
            tp_no rr = Remove(ref lista, v);
            if (rr == null)
                Console.WriteLine("Não encontrado");
            else
                Console.WriteLine("Removido com sucesso");
            break;
        case 4:
            EmOrdem(lista);
            break;
        case 5:
            PreOrdem(lista);
            break;
        case 6:
            PosOrdem(lista);
            break;
    }
}

class tp_no
{
    public tp_no esq;
    public int valor;
    public tp_no dir;
}
