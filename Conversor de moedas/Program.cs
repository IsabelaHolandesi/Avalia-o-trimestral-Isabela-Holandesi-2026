Console.OutputEncoding = System.Text.Encoding.UTF8;
//declaração de variáveis locais
float moeda, converorReal, resultado;
int escolha;
Console.WriteLine("Conversor de Moedas🪙💵");
Console.Write("Digite o Valor em Reais que você quer converter: ");
float.TryParse(Console.ReadLine()!, out moeda);
Console.WriteLine("\nDigite 1 para converter para dólar\n" +
"Digite 2 para converter para Libras\nDigite: ");
int.TryParse(Console.ReadLine(), out escolha);
switch (escolha)
{
    case 1:
        Console.Write("Digite o valor do dólar turismo: ");
        float.TryParse(Console.ReadLine()!.Replace(".", ","), out converorReal);
        resultado = moeda / converorReal;
        Console.WriteLine($"R${moeda} x U${converorReal} = U${resultado}");
        break;
    case 2:
        Console.Write("Digite o valor da libra turismo: ");
        float.TryParse(Console.ReadLine()!.Replace(".", ","), out converorReal);
        resultado = moeda / converorReal;
        Console.WriteLine($"R${moeda} x £$:{converorReal} = £$:{resultado}");
        break;
    default:
        Console.WriteLine("Digite um valor válido");
        break;
}

