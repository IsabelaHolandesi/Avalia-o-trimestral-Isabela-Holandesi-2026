Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Lavinha GoodVibe ");
Console.WriteLine("Calculadora de IMC");

/*---------------- Criação de Variáveis ----------------*/

float peso, altura, imc = 0;

Console.Write("Digite o seu peso: ");
if (!float.TryParse(Console.ReadLine()!.Replace(".", ","), out peso))
{
    Console.WriteLine("Peso inválido!");
    return;
}

Console.Write("Digite a sua altura: ");
if (!float.TryParse(Console.ReadLine()!.Replace(".", ","), out altura))
{
    Console.WriteLine("Altura inválida!");
    return;
}

/*---------------- Cálculo do IMC ----------------*/

imc = (float)(peso / Math.Pow(altura, 2));

Console.WriteLine($"\nSeu IMC é: {imc:F2}");

/*---------------- Classificação ----------------*/

if (imc < 18.5)
{
    Console.WriteLine("Você está abaixo do peso.");
}
else if (imc >= 18.5 && imc < 25)
{
    Console.WriteLine("Você está no peso ideal.");
}
else
{
    Console.WriteLine("Você está acima do peso.");
}


