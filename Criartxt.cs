// 1. O CÓDIGO DE AÇÃO FICA NO TOPO
// 1. Criando uma despesa de verdade a partir do molde
Despesa meuAlmoco = new Despesa();

Console.WriteLine("Olá, seja bem-vindo ao seu controle de despesas!"); // O 'Console.WriteLine()' é um método que escreve algo na tela e pula para a linha de baixo, ou seja, o cursor fica na linha de baixo. O '$' é para avisar que vamos usar as chaves '{}' para colocar variáveis dentro do texto. O '{meuAlmoco.Descricao}' é para mostrar o valor da propriedade 'Descricao' do objeto 'meuAlmoco'. O '{meuAlmoco.Valor}' é para mostrar o valor da propriedade 'Valor' do objeto 'meuAlmoco'. O '{meuAlmoco.Data}' é para mostrar o valor da propriedade 'Data' do objeto 'meuAlmoco'.
Console.WriteLine("Vamos registrar a despesa do seu almoço!"); // O 'Console.WriteLine()' é um método que escreve algo na tela e pula para a linha de baixo, ou seja, o cursor fica na linha de baixo. O '$' é para avisar que vamos usar as chaves '{}' para colocar variáveis dentro do texto. O '{meuAlmoco.Descricao}' é para mostrar o valor da propriedade 'Descricao' do objeto 'meuAlmoco'. O '{meuAlmoco.Valor}' é para mostrar o valor da propriedade 'Valor' do objeto 'meuAlmoco'. O '{meuAlmoco.Data}' é para mostrar o valor da propriedade 'Data' do objeto 'meuAlmoco'.

// Nome
Console.Write("Digite o seu nome: ");
string nome = Console.ReadLine()!; // O 'Console.ReadLine()' é um método que lê o que o usuário digitou e retorna como uma string, ou seja, um texto. O '!' é para avisar que o valor não vai ser nulo, ou seja, que o usuário vai digitar algo.


Console.Write($"{nome}, por favor digite seu Almoço: "); // O '!' é para avisar que o valor não vai ser nulo, ou seja, que o usuário vai digitar algo
string almoco = Console.ReadLine()!; // O 'Console.ReadLine()' é um método que lê o que o usuário digitou e retorna como uma string, ou seja, um texto. O 'decimal.Parse()' é um método que converte uma string em um número decimal, ou seja, um número com vírgula.

Console.Write($"{nome}, por favor digite o valor do seu Almoço: "); // O 'Console.Write()' é um método que escreve algo na tela, mas não pula para a linha de baixo, ou seja, o cursor fica na mesma linha. O 'decimal.Parse()' é um método que converte uma string em um número decimal, ou seja, um número com vírgula.
decimal valor = decimal.Parse(Console.ReadLine()!);  // O 'decimal.Parse()' é um método que converte uma string em um número decimal, ou seja, um número com vírgula. O 'Console.ReadLine()' é um método que lê o que o usuário digitou e retorna como uma string, ou seja, um texto. O '!' é para avisar que o valor não vai ser nulo, ou seja, que o usuário vai digitar algo.

// 2. Preenchendo os dados
meuAlmoco.Descricao = almoco; // Coloquei a descrição entre chaves para ficar mais fácil de ler
meuAlmoco.Valor = valor;   // Colocamos a letra 'm' no final para avisar que é um 'decimal'
meuAlmoco.Data = DateTime.Now;    // O C# pega a data e hora exata de agora automaticamente!


// 3. Mostrando na tela

Console.WriteLine($"SALVO! {nome} gastou R$ {meuAlmoco.Valor} com {meuAlmoco.Descricao} em {meuAlmoco.Data}");

Console.Write("Deseja Salvar essa despesa? (S/N) ");
string resposta = Console.ReadLine()!.ToUpper(); // O 'Console.ReadLine()' é um método que lê o que o usuário digitou e retorna como uma string, ou seja, um texto. O 'ToUpper()' é um método que converte todas as letras de uma string para maiúsculas, ou seja, para letras grandes. O '!' é para avisar que o valor não vai ser nulo, ou seja, que o usuário vai digitar algo.  

if (resposta == "S")
{

    // Salvar a despesa no banco de dados despesas.txt
    // ...
    
    File.AppendAllText("despesas.txt", $" {nome} gastou R$ {meuAlmoco.Valor} com {meuAlmoco.Descricao} em {meuAlmoco.Data}\n"); // O 'File.AppendAllText()' é um método que escreve um texto em um arquivo, e se o arquivo já existir, ele adiciona o texto no final do arquivo, ou seja, ele não apaga o que já tem no arquivo. O '\n' é para pular para a linha de baixo, ou seja, para cada despesa ficar em uma linha diferente.
    Console.WriteLine("Despesa salva no arquivo com sucesso!");
}
else
{
    Console.WriteLine("Despesa não salva.");
}

// ==========================================

// 2. AS CLASSES (MOLDES) FICAM LÁ NO FINAL
public class Despesa
{
    // Coloquei a interrogação (string?) para o aviso laranja sumir!
    public string? Descricao { get; set; } // O C# não tem um tipo de número com vírgula, ele tem o 'decimal' que é o mais recomendado para dinheiro
    public decimal Valor { get; set; } // O C# tem um tipo de data e hora chamado 'DateTime'
    public DateTime Data { get; set; } // O 'get; set;' é uma forma rápida de criar um método para ler e outro para escrever o valor da propriedade
}
