string especie;
string raca;
string nome;
string idade;
string cor;

Console.Clear();

Console.WriteLine("De qual espécie é seu animal? ");
especie = Console.ReadLine()!;
Console.Clear();

Console.WriteLine("De qual raça é seu animal? ");
raca = Console.ReadLine()!;
Console.Clear();

Console.WriteLine("Qual o nome do seu animal? ");
nome = Console.ReadLine()!;
Console.Clear();

Console.WriteLine("Qual a idade do seu animal? ");
idade = Console.ReadLine()!;
Console.Clear();

Console.WriteLine("Qual a cor do seu animal? ");
cor = Console.ReadLine()!;
Console.Clear();

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+===========================================================+");


Console.Write("|                  ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Pet Hotel 'Carroçinha'");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("                   |");

Console.WriteLine("+===========================================================+");

Console.Write("| ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Espécie: ");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write(especie.Trim()
                     .ToUpper()
                     .PadLeft(18, '.')
                     .Substring(0, 18));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write(" | ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Raça: ");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write(raca.Trim()
                  .ToUpper()
                  .PadLeft(21, '.')
                  .Substring(0, 21));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" |");


Console.WriteLine("+===========================================================+");

Console.Write("| ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Atende pela alcunha de: ");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write(nome.Trim()
                  .ToUpper()
                  .PadLeft(33, '.')
                  .Substring(0, 33));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" |");

Console.Write("| ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Idade: ");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write(idade.Trim()
                   .ToUpper()
                   .PadLeft(20, '.')
                   .Substring(0, 20));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write(" | ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Pelagem/cor: ");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write(cor.Trim()
                 .ToUpper()
                 .PadLeft(14, '.')
                 .Substring(0, 14));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" |");

Console.WriteLine("+===========================================================+");
Console.ResetColor();