Console.Write("Digite seu nome: ");
string nome = Console.ReadLine()!;

Console.WriteLine($"Olá, {nome}! Quantos anos você tem?");
int age = int.Parse(Console.ReadLine()!);


// O CÉREBRO ENTRA EM ACÃO AQUI
if (age >= 60) // Se a idade for MAIOR ou IGUAL a 60...
{
   Console.WriteLine($"{nome}, você tá com o pé na cova, hein?"); // Imprime essa mensagem
}

else if (age >= 30) // Se não for 60, mas for MAIOR ou IGUAL a 30...
{
   Console.WriteLine($"{nome}, você tá na flor da idade!"); // Imprime essa mensagem
}

else if (age >= 18) // Se não for 60 ou 30, mas for MAIOR ou IGUAL a 18...
{
   Console.WriteLine($"{nome}, tá na flor da idade! Bora codar!"); // Imprime essa mensagem
}

else // Se não for nenhuma das opções anteriores...
{
   Console.WriteLine($"{nome}, você é um jovem cheio de energia!"); // Imprime essa mensagem
}
