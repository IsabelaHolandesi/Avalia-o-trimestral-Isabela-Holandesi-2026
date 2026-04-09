using System;
public class HelloWorld


{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        /*Digitar o valor do raio e trazer o calculo da área do circulo*/
        Console.Write("Digite o valor do Raio: ");
        float.TryParse(Console.ReadLine(), out float raio);
        float area = (float)(Math.Pow(raio, 2.0) * (float)Math.PI);
        Console.WriteLine($"O valor da área é A = {area} 🤩");
    }
}
