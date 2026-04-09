Console.OutputEncoding = System.Text.Encoding.UTF8;
// declarar variaveis
int cont = 0;
Console.WriteLine("Calculadora de números primos🧮");
Console.WriteLine("digite um número");
int.TryParse(Console.ReadLine(), out int primo);
for (int i = 1; i <= primo; i++)
{
    if (primo % i == 0)
    {
        cont++;
    }
    Console.Write($"{i}➡️");
}
Console.Write("🤯");
if (cont == 2)
{
    Console.WriteLine($"\n0 número {primo} é primo");
}
else
    {
    Console.WriteLine($"0 número {primo} não é primo");
}

