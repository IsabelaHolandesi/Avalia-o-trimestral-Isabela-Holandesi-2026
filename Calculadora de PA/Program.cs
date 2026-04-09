Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Calculadora PA 😁");
//variaveis
int salto, termos, resultado = 0;
Console.Write("Digite o nº de Termos: ");
int.TryParse(Console.ReadLine(), out termos);
Console.Write("Digite o nº do salto: ");
int.TryParse(Console.ReadLine(), out salto);
for (int i = 0; i <= termos; i++)
{
    resultado = resultado + salto;
    Console.Write($"{resultado}➡️");
}
Console.Write("😍😘");

