using System;
public class HelloWorld


{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Digite o capital total: ");
        float.TryParse(Console.ReadLine(), out float p1);
        Console.Write("Digite o tempo: ");
        float.TryParse(Console.ReadLine(), out float p2);
        Console.Write("Digite a taxa de juros: ");
        float.TryParse(Console.ReadLine(), out float p3);
        float x = (p1 * p2 * p3 / 100);
        Console.WriteLine($"Juros Simples = {x}");
    }
}
