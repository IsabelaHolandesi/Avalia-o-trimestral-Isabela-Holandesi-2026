// REGRA 1 - Troll é inimigo
if (classe.ToLower() == "troll")
{
    Console.WriteLine("🚫 Troll detectado! Expulso da guilda imediatamente!");
    return;
}

if (classe != "Troll" && !(nivel < 5))
{
    Console.WriteLine("✅ Herói autorizado a entrar na guilda!");
}
else
{
    Console.WriteLine("⚠️ Nível muito baixo para enfrentar o dragão.");
}

// REGRA 2 - Cálculo do Poder Base
float poderBase = (nivel * 10) + (hp / 2) - 5;

Console.WriteLine($"\n💪 Poder Base de {nome}: {poderBase:F2}");

// REGRA 3 - Dano Crítico
if (poderBase % 2 == 0)
{
    Console.WriteLine("⚔️✨ Ataque Crítico disponível! O herói tem vantagem!");
}

bool podeAtacar = false;

// REGRA 4 - Magia
if (classe == "Mago" || classe == "Druida" || classe == "Clérigo")
{
    if (mana >= 30 && nivel <= 100)
    {
        Console.WriteLine("🔮 O herói lança um poderoso feitiço contra o dragão!");
        podeAtacar = true;
    }
    else
    {
        Console.WriteLine("🪵 O cajado falha! Mana insuficiente.");
    }
}

// REGRA 5 - Ataque físico
else if (classe == "Guerreiro" || classe == "Anão" || classe == "Elfo")
{
    if (hp > 20 && poderBase > 50)
    {
        Console.WriteLine("🗡️ O herói avança com um ataque físico poderoso!");
        podeAtacar = true;
    }
    else
    {
        Console.WriteLine("😬 O herói está fraco demais para lutar.");
    }
}

// REGRA 6 - Suborno
if (!podeAtacar)
{
    Console.WriteLine("\n💰 Tentando subornar o dragão...");

    if (ouro > 1000 || classe == "Anão")
    {
        Console.WriteLine("🐉 O dragão aceita o suborno e deixa o herói fugir!");
    }
    else
    {
        Console.WriteLine("🔥 O dragão não aceita o suborno...");
        Console.WriteLine("🍖 Resultado: O herói virou churrasco de dragão!");
    }
}

Console.WriteLine("\n🏁 Fim da avaliação da guilda.");
    }
}
