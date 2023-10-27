//10) Elabore um programa que verifica se uma dada expressão é válida em relação aos abre e fecha parênteses, colchetes e chaves. Exemplos:

//a) a = b + (c -d) * (e – f) - válida

//b) b = [c – d) - inválida

//c) while (m < (n[8] + o)) { m = m + 1; } - válida

//d) for (i = 1; i <= tl; i++ - inválida

bool vazio(int top)
{
    return top == -1;
}

void adicionar(char[] stack, ref int top, char var)
{
    stack[++top] = var;
}

char remove(char[] stack, ref int top)
{
    return stack[top--];
}

void verificar(char[] stack, ref int top)
{
    int parenteses = 0;
    int colchetes = 0;
    int chaves = 0;
    while(!vazio(top))
    {
        char aux = remove(stack, ref top);
        switch(aux)
        {
            case '(': parenteses+=1; break;
            case ')': parenteses-=1; break;
            case '{': chaves+=1; break;
            case '}': chaves-=1; break;
            case '[': colchetes+=1; break;
            case ']': colchetes-=1; break;
        }
    }
    if(parenteses == 0 && chaves == 0 && colchetes == 0)
    {
        Console.WriteLine("Válido");
    }
    else
    {
        Console.WriteLine("Inválido");
    }
}

Console.WriteLine("Digite a epressão: ");
string text = Console.ReadLine();
int max = text.Length;
char[] stack = new char[max];
int top = -1;
for(int i=0;i<max;i++)
{
    adicionar(stack,ref top, text[i]);
}
verificar(stack, ref top);


