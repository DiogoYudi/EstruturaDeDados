//18) Faça um programa que utilize lista encadeada e que tenha as opções a seguir. O nó deve conter os atributos: nome, idade, whats e prox.
	
//Incluir conforme apresentado em aulas

//Para alterar, consulte pelo nome. Se encontrar, exiba os valores atuais e permita a alteração. Caso não encontre, exiba mensagem de não encontrado.

//Para excluir, procure pelo nome. Se encontrar, exiba os valores atuais e permita a exclusão. Caso não encontre, exiba mensagem de não encontrado.

//Na opção exibir, exiba todos os registros.

void Cadastre(ref tp_no l)
{
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Idade: ");
    string idade = Console.ReadLine();
    Console.Write("Whats: ");
    string whats = Console.ReadLine();
    Insere(ref l, nome, idade, whats);
}

void Insere(ref tp_no l, string nome, string idade, string whats)
{
    tp_no no = new tp_no();
    no.nome = nome;
    no.idade = idade;
    no.whats = whats;
    if (l != null)
        no.prox = l;
    l = no;
}

void Consulte(string n, ref tp_no atual, ref tp_no anterior, tp_no l)
{

    atual = l;
    while (atual != null && atual.nome != n)
    { 
        anterior = atual;
        atual = atual.prox;
    }

}

void Altere(ref tp_no l)
{
    tp_no atual = null, anterior = null;
    Console.Write("Informe o nome para a alteração: ");
    string n = Console.ReadLine();

    Consulte(n, ref atual, ref anterior, l);
    if (atual == null)
        Console.WriteLine("Nome não encontrado");
    else
    {
        Console.WriteLine("Dados atuais");
        Console.WriteLine($"Nome: {atual.nome}");
        Console.WriteLine($"Idade: {atual.idade}");
        Console.WriteLine($"Whats: {atual.whats}");
        Console.Write("Novo nome: ");
        atual.nome = Console.ReadLine();
        Console.Write("Nova idade: ");
        atual.idade = Console.ReadLine();
        Console.Write("Novo whats: ");
        atual.whats = Console.ReadLine();

    }
}

void Remove(ref tp_no l)
{
    Console.Write("Informe o nome para a exclusão: ");
    string n = Console.ReadLine();
    tp_no anterior = null, atual = null;
    Consulte(n, ref atual, ref anterior, l);
    if (atual != null)
    {
        if (atual.prox == null)
        { 
            anterior.prox = null;
        }
        else if (anterior == null)
        {
            l = atual.prox;
            atual.prox = null;
        }
        else
        {
            anterior.prox = atual.prox;
            atual.prox = null;
        }
        Console.WriteLine("Excluido com sucesso");
    }
    else
        Console.WriteLine("Não encontrado");
  
}

void Exibir(tp_no l)
{
    while (l != null)
    {
        Console.WriteLine($"Nome: {l.nome}");
        Console.WriteLine($"Idade: {l.idade}");
        Console.WriteLine($"Whats: {l.whats}");
        Console.WriteLine("---------------------------------------------------------------");
        l = l.prox;
    }
}

tp_no lista = null;
int op;
int menu()
{   Console.WriteLine("MENU");
    Console.WriteLine("1. Inserir dados");
    Console.WriteLine("2. Alterar dados");
    Console.WriteLine("3. Excluir dados");
    Console.WriteLine("4. Exibir todos os registros");
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
            Cadastre(ref lista);
            break;
        case 2:
            Altere(ref lista);
            break;
        case 3:
            Remove(ref lista);
            break;
        case 4:
            Exibir(lista);
            break;
    }
}

class tp_no
{
    public string nome, idade, whats;
    public tp_no prox;
}
