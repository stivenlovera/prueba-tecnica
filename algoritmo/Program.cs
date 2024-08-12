// See https://aka.ms/new-console-template for more information


using algoritmo;

var seccion = new Sections();

Console.WriteLine("problema 1 escriba un texto");
Console.WriteLine("escriba un texto");
string text = Console.ReadLine()!;
var problem1 = seccion.problem1(text);
Console.WriteLine($"resultado {problem1}");
Console.WriteLine("problema 2 escriba dos numeros");
Console.WriteLine("digito inicial");
int initial = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("digito final");
int final = Convert.ToInt32(Console.ReadLine());
var problem2 = seccion.problem2(initial, final);
Console.WriteLine($"resultado {problem2}");