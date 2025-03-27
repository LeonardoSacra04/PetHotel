string especie, raca, nome, idade, cor;

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

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("+=========================================================+");


Console.Write("|                 ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Pet Hotel 'Carroçinha'");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("                  |");

Console.WriteLine("+=========================================================+");

Console.Write("| ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Espécie: ");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write(especie.Trim().ToUpper().PadLeft(17, '.').Substring(0, 17));
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write(" | ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Raça: ");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write(raca.Trim().ToUpper().PadLeft(20, '.').Substring(0, 20));
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(" |");


Console.WriteLine("+=========================================================+");

Console.Write("| ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Nome: ");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write(nome.Trim().ToUpper().PadLeft(49, '.').Substring(0, 49));
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(" |");

Console.Write("| ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Idade: ");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write(idade.Trim().ToUpper().PadLeft(19, '.').Substring(0, 19));
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write(" | ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Cor: ");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write(cor.Trim().ToUpper().PadLeft(21, '.').Substring(0, 21));
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(" |");

Console.WriteLine("+=========================================================+");
Console.ResetColor();