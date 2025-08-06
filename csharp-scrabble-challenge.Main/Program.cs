// See https://aka.ms/new-console-template for more information

using csharp_scrabble_challenge.Main;

Console.WriteLine("enter a word: ");
string input = Console.ReadLine();
Scrabble scr = new Scrabble(input);

int score = scr.score();

Console.WriteLine($"{score}");
