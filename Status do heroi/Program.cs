string nome = "Sergio";
int ataqueBase = 40;
int bonusEspada = 15;
int ataqueTotal = ataqueBase + bonusEspada;
double vidaMonstro = 200.5;
double vidaRestante = vidaMonstro - 75.5;
float moedas = 30.5f;
var moedasFinais = moedas * 3f;
long xpTotal = 8000000000;
long mediaXp = xpTotal / 2;
bool venceuBatalha = true;

Console.WriteLine("Status do Herói");
Console.WriteLine("Nome: " + nome);
Console.WriteLine("Ataque total: " + ataqueTotal);
Console.WriteLine("Vida restante do monstro: " + vidaRestante);
Console.WriteLine("Moedas após a batalha: " + moedasFinais);
Console.WriteLine("Média de XP: " + mediaXp);
Console.WriteLine("Venceu a batalha? " + venceuBatalha);

