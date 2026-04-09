Console.WriteLine("--- Calculadora de Raiz Quadrada ---");

Console.Write("Digite um número: ");
if (double.TryParse(Console.ReadLine(), out double numero))
{
    if (numero >= 0)
    {
        double raiz = Math.Sqrt(numero);
        Console.WriteLine($"A raiz quadrada de {numero} é: {raiz:F2}");
    }
    else
    {
        Console.WriteLine("Erro: Não existe raiz quadrada real de número negativo.");
    }
}
else
{
    Console.WriteLine("Entrada inválida. Por favor, digite um número.");
}

Console.WriteLine("\nPressione qualquer tecla para sair...");
