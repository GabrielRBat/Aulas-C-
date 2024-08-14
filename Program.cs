// See https://aka.ms/new-console-template for more information

int a = 10;
int b = 5;
long c = 100;
float d = 1.1f;
double e = 1.1;

var x = 100;
var str = "Tmj lek q isso";

Console.WriteLine("Digite a nota 1: ");
var nota1 = Console.ReadLine();

Console.WriteLine("Digite a nota 2: ");
var nota2 = Console.ReadLine();

double mediaArt = (Convert.ToDouble(nota1) + Convert.ToDouble(nota2)) / 2;

if(mediaArt >= 6)
{
    Console.WriteLine("Nota total: " + mediaArt);
    Console.WriteLine("Aluno aprovado!");
}

Console.WriteLine("Nota total: " + mediaArt);
Console.WriteLine("Aluno reprovado! L");