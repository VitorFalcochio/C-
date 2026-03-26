Console.Write("Digite seu nome: ");
string nome = Console.ReadLine()!;

if (nome == "Vitor")
{
    Console.Write($"Olá, {nome}!\n");
    Console.Write("Digite até que valor você deseja contar: ");
    int limite = int.Parse(Console.ReadLine()!);

    int contador = 1; // 0. A variável de controle do laço, que inicia com o valor 1

    while (contador <= limite)  // 1. A condição OBRIGATORIAMENTE fica entre parênteses
    {                      // 2. A chave ABRINDO diz onde o laço começa
        Console.WriteLine($"Contador: {contador}");
        contador++;        // 3. Atalho do C# para somar +1 (igual a contador += 1)
    }                      // 4. A chave FECHANDO diz onde o laço termina

}

else
{
    Console.WriteLine("Olá, " + nome + "!");
}
