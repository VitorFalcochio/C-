// Jogo de Adivinhação em C#
Console.WriteLine("Olá Bem vindo ao jogo de adivinha");


// Nome - COnfirmação de nome para o Jogo

Console.Write("Digite seu nome: ");
string nome = Console.ReadLine()!;

// Cria uma lista com os nomes dos seus amigos
string[] amigos = { "João", "Miguel", "Sophia", "Arthur", "Helena", "Gabriel", "Alice", "Lucas", "Laura", "Mateus", "Valentina" };

// Verifica se o nome digitado está dentro dessa lista
if (amigos.Contains(nome))
{
    Console.WriteLine("Bem vindo seu viadinho, vamos jogar!");
}
// Se o nome não estiver na lista, exibe uma mensagem de boas-vindas genérica
else
{
    Console.WriteLine($"Bem vindo {nome}, vamos jogar!");
}

// Jogo de adivinhação
Console.WriteLine("Digite um número entre 1 e 100:");
int numeroSecreto = new Random().Next(1, 101);


// Loop para o jogador tentar adivinhar o número secreto
while (true)
{    // Lê o palpite do jogador e verifica se é um número válido
    if (int.TryParse(Console.ReadLine(), out int palpite))
    {   // Compara o palpite com o número secreto e dá dicas ao jogador
        if (palpite < numeroSecreto)
        {
            Console.WriteLine("Tente um número maior.");
        }

        // Se o palpite for maior que o número secreto, informa ao jogador para tentar um número menor
        else if (palpite > numeroSecreto)
        {
            Console.WriteLine("Tente um número menor.");
        }
        // Se o palpite for igual ao número secreto, parabeniza o jogador e encerra o jogo
        else
        {
            Console.WriteLine("Parabéns! Você acertou o número secreto!");
            break;
        }
    }
    // Se o palpite não for um número válido, informa ao jogador para digitar um número válido
    else
    {
        Console.WriteLine("Por favor, digite um número válido.");
    }
}
