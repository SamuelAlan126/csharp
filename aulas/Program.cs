// comentário
// Console.WriteLine("Qualquer coisa");
 
// 1. VARIÁVEIS E TIPOS
 
var n = 10;
int x = 1;
double preco = 10.50;
char inicial = 'M';
string nome = "Matheus";
bool status = true;
int idade = 31;
 
Console.WriteLine($"Status: {status}");
Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Idade: {idade}");


// 2. EXERCÍCIOS
// Declaração e Impressão
string nome = "Samuel";
int idade = 17;
bool status = true;
int numero = 22;

Console.WriteLine($"nome:{nome}");
Console.WriteLine($"idade:{idade}");
Console.WriteLine($"status:{status}");

//Entrada de usuario
Console.Write("Digite o seu Nome:");
string nomes = Console.ReadLine();

//Conversão de tipos 
Console.Write("Digite a sua Idade:");
int idades = int.Parse(Console.ReadLine());

//maior ou menor de idade
if (idades >= 18)
{
    Console.WriteLine($"Olá {nomes}, você é maior de idade.");
}
else
{
    Console.WriteLine($"Olá {nomes}, você é menor de idade.");
}

//classificação de idade
if (idades < 12)
{
    Console.WriteLine("Criança");
}
else if (idades >= 12 && idades < 18)
{
    Console.WriteLine("Adolescente");
}
else
{
    Console.WriteLine("Adulto");
}
// Classificação por idade
switch (idades)
{
    case int n when (n >= 0 && n <= 11):
        Console.WriteLine("Criança");
        break;
    case int n when (n >= 12 && n <= 17):
        Console.WriteLine("Adolescente");
        break;
    case int n when (n >= 18):
        Console.WriteLine("Adulto");
        break;
    default:
        Console.WriteLine("Idade inválida");
        break;
}
//Numero positivo, negativo ou zero, informe se é positivo, negativo ou zero
if (numero <= 0)
{
    Console.WriteLine("negativo");
}
else if (idades >= 12 && idades < 18)
{
    Console.WriteLine("Adolescente");
}
else
{
    Console.WriteLine("Adulto");
}
