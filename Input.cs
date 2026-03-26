// Nome

using System.ComponentModel;

Console.Write("Digite seu nome: ");
string name = Console.ReadLine()!;
Console.WriteLine($"Olá, {name}!");

Console.WriteLine($"{name}, quantos anos você tem?");
int age = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{name}, você tem {age} anos!");
Console.WriteLine($"{name}, você está velho pra caralho! HAHAHAHAHH");


// Número inteiro
Console.Write("Digite o valor que deseja: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Você digitou o número {number1}");
