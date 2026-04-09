using System;

class Program
{
    static void Main()
    {
        // Ativar suporte a emojis e símbolos
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("🌡️ --- Conversor de Temperaturas --- 🌡️\n");

        Console.WriteLine("Escolha uma conversão:");
        Console.WriteLine("1 - Celsius (°C) para Fahrenheit (°F)");
        Console.WriteLine("2 - Fahrenheit (°F) para Celsius (°C)");
        Console.WriteLine("3 - Kelvin (K) para Celsius (°C)");
        Console.WriteLine("4 - Kelvin (K) para Fahrenheit (°F)");
        Console.Write("\nDigite a opção desejada: ");

        if (int.TryParse(Console.ReadLine(), out int opcao))
        {
            Console.Write("\nDigite a temperatura: ");

            if (float.TryParse(Console.ReadLine(), out float valor))
            {
                switch (opcao)
                {
                    case 1:
                        float f = (valor * 9 / 5) + 32;
                        Console.WriteLine($"\n🔥 {valor:F2}°C = {f:F2}°F");
                        break;

                    case 2:
                        float c = (valor - 32) * 5 / 9;
                        Console.WriteLine($"\n❄️ {valor:F2}°F = {c:F2}°C");
                        break;

                    case 3:
                        float c2 = valor - 273.15f;
                        Console.WriteLine($"\n❄️ {valor:F2}K = {c2:F2}°C");
                        break;

                    case 4:
                        float f2 = (valor - 273.15f) * 9 / 5 + 32;
                        Console.WriteLine($"\n🔥 {valor:F2}K = {f2:F2}°F");
                        break;

                    default:
                        Console.WriteLine("❌ Opção inválida!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("❌ Erro: Digite apenas números para a temperatura!");
            }
        }
        else
        {
            Console.WriteLine("❌ Erro: Digite apenas números para a opção!");
        }

        Console.WriteLine("\nPressione Enter para sair...");
        Console.ReadLine();
    }
}
