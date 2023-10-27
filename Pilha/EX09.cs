//9) Escreva um programa para conhecer uma frase e exibi-la com as PALAVRAS invertidas. Por exemplo, a frase “Jose da Silva” deve sair “esoJ ad avliS”.

void Insere(char[] p, ref int t, char f)
{
    p[t] = f;
    t = t + 1;
}

char Remove(char[] p, ref int t)
{
    t = t - 1;
    return(p[t]);
}

bool EstaVazia(int t)
{
    if (t == 0)
        return true;
    else
        return false;
}

void invert(char[] p, ref int t, string f)
{
    int i = 0;
    while (i < f.Length)
    {
        while (i < f.Length && f[i] != ' ')
        {
            Insere(p, ref t, f[i]);
            i++;
        }
        while (EstaVazia(t) != true)
        {
            char a = Remove(p, ref t);
            Console.Write(a);
        }
        Console.Write(' ');
        i++;
    }
}


Console.WriteLine("Informe uma palavra/frase para ser invertido: ");
string frase = Console.ReadLine();
int n = frase.Length;
char[] pilha = new char [n];
int topo = 0; 
invert(pilha, ref topo, frase);
