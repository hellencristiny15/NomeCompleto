// See https://aka.ms/new-console-template for more information
Console.WriteLine("PRIMEIRO NOME :");
string nome = Console.ReadLine();
Console.WriteLine("SOBRENOME :");
string sobrenome = Console.ReadLine();
Console.WriteLine($"NOME COMPLETO : {nome} {sobrenome}");
Console.WriteLine($"NOME COMPLETO EM MAIUSCULO : {nome.ToUpper()} {sobrenome.ToUpper()}");
Console.WriteLine($"NOME COMPLETO EM MINUSCULO : {nome.ToLower()} {sobrenome.ToLower()}");
