Console.Write("Digite a quantidade de termos: ");
int n = int.Parse(Console.ReadLine());

int a = 0;
int b = 1;

for (int i = 0; i < n; i++)
{
    Console.Write(a + " ");

    int soma = a + b;
    a = b;
    b = soma;
}
