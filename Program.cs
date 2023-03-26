//Texto vazio Atividade web

String Texto;
Console.WriteLine("----TExto Vazio----");

Console.Write("Digite um Texto:");
Texto = Console.ReadLine()!;

Console.WriteLine(String.IsNullOrEmpty(Texto.Trim()));
