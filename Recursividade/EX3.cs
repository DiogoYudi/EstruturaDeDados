//3) Implemente uma versão recursiva da seguinte função iterativa. Faça a repetição recursiva somente do for, não precisa fazer da expressão i * i * i.
//void cubos (int n)
//{
//for (int i = 1; i <= n; i++)
//Controle.WrilteLine(i * i * i);
//}

void cubos(int n)
{
    if (n == 0)
        Console.WriteLine("1");
    else
        for(int i = 1; i<= n; i++)
            Console.WriteLine(i + "x" + i + "x" + i + "=" + i*i*i);
}

Console.Write("Escolha um número: ");
int nu = Convert.ToInt32(Console.ReadLine());
cubos(nu);
